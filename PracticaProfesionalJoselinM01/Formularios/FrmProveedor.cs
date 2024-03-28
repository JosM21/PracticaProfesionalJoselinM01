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
    public partial class FrmProveedor : Form
    {


        private Logica.Models.Proveedor MiProveedorLocal { get; set; }
        private DataTable ListarProveedor {  set; get; }
        public FrmProveedor()
        {
            InitializeComponent();
            MiProveedorLocal = new Logica.Models.Proveedor();   
            ListarProveedor = new DataTable();

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaProveedores();
            ActivarAgregar();

        }

        private void CargarListaProveedores()
        {
            ListarProveedor = new DataTable();

            if (CBoxVerActivos.Checked)
            {
                ListarProveedor = MiProveedorLocal.ListarActivos();
            }
            else
            {
                ListarProveedor = MiProveedorLocal.ListarInactivos();
            }

            DgLista.DataSource = ListarProveedor;


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


                int IdProveedor = Convert.ToInt32(MiFila.Cells["CidProveedor"].Value);

                MiProveedorLocal = new Logica.Models.Proveedor();
                MiProveedorLocal.IdProveedor = IdProveedor;
                MiProveedorLocal = MiProveedorLocal.ConsultarPorIDRetornaProveedor();

                if (MiProveedorLocal != null && MiProveedorLocal.IdProveedor > 0)
                {

                    TxtProveedorID.Text = Convert.ToString(MiProveedorLocal.IdProveedor);
                    TxtProveedorNombre.Text = MiProveedorLocal.Nombre;
                    TxtProveedorCedula.Text = MiProveedorLocal.Cedula;
                    TxtProveedorCorreo.Text = MiProveedorLocal.Email;
                    TxtProveedorTelefono.Text = MiProveedorLocal.Telefono;
                    TxtProveedorDireccion.Text = MiProveedorLocal.Direccion;

                    ActivarEditarEliminar();

                }

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarAgregar();
            DgLista.ClearSelection();
        }

        private void LimpiarFormulario()
        {
            TxtProveedorID.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorCorreo.Clear();
            TxtProveedorDireccion.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorTelefono.Clear();
        }


        private bool ValidarDatosDigitados()
        {
            bool R = false;


            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProveedorCorreo.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProveedorDireccion.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProveedorTelefono.Text.Trim())
                )
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar una cédula valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProveedorCorreo.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un email valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorCorreo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProveedorDireccion.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar una direccion valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorDireccion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtProveedorTelefono.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un teléfono valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorTelefono.Focus();
                    return false;
                }


            }



            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {


                bool NombreOK;


                MiProveedorLocal = new Logica.Models.Proveedor();



                MiProveedorLocal.Nombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.Cedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.Telefono = TxtProveedorTelefono.Text.Trim();
                MiProveedorLocal.Email = TxtProveedorCorreo.Text.Trim();
                MiProveedorLocal.Direccion = TxtProveedorDireccion.Text.Trim();




                NombreOK = MiProveedorLocal.ConsultarPorDescripcion();

                if (NombreOK == false)
                {
                    string msg = string.Format("¿Desea agregar el proveedor {0}?", MiProveedorLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiProveedorLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Proveedor guadado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaProveedores();

                        }
                        else
                        {
                            MessageBox.Show("Proveedor no guadado correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (NombreOK)
                    {
                        MessageBox.Show("El proveedor con ese nombre ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }

                }

            }

        }
    }
}
