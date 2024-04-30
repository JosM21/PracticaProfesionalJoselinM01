using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalJoselinM01.Formularios
{
    public partial class FrmUsuario : Form
    {

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuario { get; set; }

        public FrmUsuario()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();

            ListaUsuario = new DataTable();

        }



        //PONER EN TODOS LOS FORMULARIOS DE GESTION
        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.MiFormPrincipal;


            CargarListaRoles();

            CargarListaUsuarios();

            ActivarAgregar();


        }//HASTA AQUI


        private void CargarListaUsuarios()
        {
            ListaUsuario = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CBoxVerActivos.Checked)
            {
                ListaUsuario = MiUsuarioLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaUsuario = MiUsuarioLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListaUsuario;


        }


        private void CargarListaRoles()
        {


            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable Dt = new DataTable();

            Dt = MiRol.Listar();



            if (Dt != null && Dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descripcion";
                CbRolesUsuario.DataSource = Dt;
                CbRolesUsuario.SelectedIndex = -1;
            }




        }



        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }


        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdUsuario = Convert.ToInt32(MiFila.Cells["CidUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal.IdUsuario = IdUsuario;
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();




                if (MiUsuarioLocal != null && MiUsuarioLocal.IdUsuario > 0)
                {

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.IdUsuario);
                    TxtUsuarioNombre.Text = MiUsuarioLocal.Nombre;
                    TxtUsuarioCedula.Text = MiUsuarioLocal.Cedula;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.Email;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.Direccion;

                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.IdUsuarioRol;

                    ActivarEditarEliminar();

                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }




        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            bool R = false;


            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)

            {
                if (OmitirPassword)
                {

                    R = true;

                }
                else
                {

                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {

                        R = true;

                    }
                    else
                    {
                        MessageBox.Show("Debe digitar una contraseña valida", "Error de validacion", MessageBoxButtons.OK);
                        TxtUsuarioContrasennia.Focus();
                        return false;
                    }
                }
            }

            else
            {
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una telefono valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }

                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar una rol valido", "Error de validacion", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;


                }


            }

            return R;
        }

        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioContrasennia.Clear();
            TxtUsuarioDireccion.Clear();
            CbRolesUsuario.SelectedIndex = -1;
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {


                bool CedulaOK;
                bool EmailOK;

                MiUsuarioLocal = new Logica.Models.Usuario();



                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.Email = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                //composiciones
                MiUsuarioLocal.MiRolTipo.IdUsuarioRol = Convert.ToInt32(CbRolesUsuario.SelectedValue);


                CedulaOK = MiUsuarioLocal.ConsultarPorCedula();
                EmailOK = MiUsuarioLocal.ConsultarPorEmail();

                if (CedulaOK == false && EmailOK == false)
                {
                    string msg = string.Format("¿Desea agregar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Usuario guadado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("Usuario no guadado correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (CedulaOK)
                    {
                        MessageBox.Show("El usuario con esa cedula ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                    if (EmailOK)
                    {
                        MessageBox.Show("El usuario con esa Email ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                }




            }


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados(true))
            {
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Email = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.MiRolTipo.IdUsuarioRol = Convert.ToInt32(CbRolesUsuario.SelectedValue);


                if (MiUsuarioLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el usuario? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Modificar())
                        {
                            MessageBox.Show("El usuario se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaUsuarios();

                        }

                    }

                }

            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiUsuarioLocal.IdUsuario > 0 && MiUsuarioLocal.ConsultarPorID())
            {

                if (CBoxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar el usuario?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaUsuarios();
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el usuario?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            MessageBox.Show("El usuario ha sido activado satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaUsuarios();
                        }

                    }

                }


            }

        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);

        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);

        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);

        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e,false,true);

        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Validaciones.CaracteresTexto(e);

        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);

        }

        private void TxtUsuarioCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electronico es incorrecto", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();

                }

            }
        }

        private void CBoxVerActivos_CheckedChanged(object sender, EventArgs e)
        {

            CargarListaUsuarios();

            if (CBoxVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaUsuarios();
        }

        private void DgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
