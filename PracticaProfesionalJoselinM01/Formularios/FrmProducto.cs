using Logica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalJoselinM01.Formularios
{
    public partial class FrmProducto : Form
    {

        private Logica.Models.Producto MiProductoLocal { get; set; }
        private DataTable ListaProducto { get; set; }


        public FrmProducto()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Models.Producto();

            ListaProducto = new DataTable();


        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaCategorias();
            CargarListaMarcas();
            CargarListaProveedores();
            CargarListaProducto();
            ActivarAgregar();


        }


        private void CargarListaProducto()
        {
            ListaProducto = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CBoxVerActivos.Checked)
            {
                ListaProducto = MiProductoLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaProducto = MiProductoLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListaProducto;

        }

        private void CargarListaCategorias()
        {


            Logica.Models.Categoria MiCategoria = new Logica.Models.Categoria();

            DataTable Dt = new DataTable();

            Dt = MiCategoria.Listar();



            if (Dt != null && Dt.Rows.Count > 0)
            {
                CbCategoria.ValueMember = "ID";
                CbCategoria.DisplayMember = "Descripcion";
                CbCategoria.DataSource = Dt;
                CbCategoria.SelectedIndex = -1;


            }
        }

        private void CargarListaMarcas()
        {


            Logica.Models.Marca MiMarca = new Logica.Models.Marca();

            DataTable Dt = new DataTable();

            Dt = MiMarca.Listar();



            if (Dt != null && Dt.Rows.Count > 0)
            {
                CbMarca.ValueMember = "ID";
                CbMarca.DisplayMember = "Descripcion";
                CbMarca.DataSource = Dt;
                CbMarca.SelectedIndex = -1;


            }
        }

        private void CargarListaProveedores()
        {


            Logica.Models.Proveedor MiProveedor = new Logica.Models.Proveedor();

            DataTable Dt = new DataTable();

            Dt = MiProveedor.Listar();



            if (Dt != null && Dt.Rows.Count > 0)
            {
                CbProveedor.ValueMember = "ID";
                CbProveedor.DisplayMember = "Nombre";
                CbProveedor.DataSource = Dt;
                CbProveedor.SelectedIndex = -1;


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


                int IdProducto = Convert.ToInt32(MiFila.Cells["CidProducto"].Value);

                MiProductoLocal = new Logica.Models.Producto();
                MiProductoLocal.IdProducto = IdProducto;
                MiProductoLocal = MiProductoLocal.ConsultarPorIDRetornaProducto();

                if (MiProductoLocal != null && MiProductoLocal.IdProducto > 0)
                {

                    TxtProductoID.Text = Convert.ToString(MiProductoLocal.IdProducto);
                    TxtProductoNombre.Text = MiProductoLocal.Nombre;
                    TxtStock.Text = Convert.ToString(MiProductoLocal.Stock);



                    CbCategoria.SelectedValue = MiProductoLocal.MiCategoria.IdCategoria;
                    CbMarca.SelectedValue = MiProductoLocal.MiMarca.IdMarca;
                    CbProveedor.SelectedValue = MiProductoLocal.MiProveedor.IdProveedor;

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

        private void LimpiarFormulario()
        {
            TxtProductoID.Clear();
            TxtProductoNombre.Clear();
            TxtStock.Clear();

            CbCategoria.SelectedIndex = -1;
            CbMarca.SelectedIndex = -1;
            CbProveedor.SelectedIndex = -1;
        }


        private bool ValidarDatosDigitados()
        {
            bool R = false;
           

            // int.TryParse(item["cantidad"].ToString(), out number)

            if (!string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()) &&
              

                CbCategoria.SelectedIndex > -1 &&
                 CbMarca.SelectedIndex > -1 &&
                 CbProveedor.SelectedIndex > -1)


            {
                R = true;

            }

            else
            {
                if (string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar un nombre valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtProductoNombre.Focus();
                    return false;
                }

                 {

                    MessageBox.Show("Debe digitar un stock valido", "Error de validacion", MessageBoxButtons.OK);
                    TxtStock.Focus();
                    return false;
                 }


                if (CbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar una categoria valida", "Error de validacion", MessageBoxButtons.OK);
                    CbCategoria.Focus();
                    return false;
                }

                if (CbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar una marca valida", "Error de validacion", MessageBoxButtons.OK);
                    CbMarca.Focus();
                    return false;
                }

                if (CbProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe digitar un proveedor valido", "Error de validacion", MessageBoxButtons.OK);
                    CbCategoria.Focus();
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

                MiProductoLocal = new Logica.Models.Producto();



                MiProductoLocal.Nombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.Stock = Convert.ToInt32(TxtStock.Text.Trim());


                //composiciones
                MiProductoLocal.MiCategoria.IdCategoria = Convert.ToInt32(CbCategoria.SelectedValue);
                MiProductoLocal.MiMarca.IdMarca = Convert.ToInt32(CbMarca.SelectedValue);
                MiProductoLocal.MiProveedor.IdProveedor = Convert.ToInt32(CbProveedor.SelectedValue);



                NombreOK = MiProductoLocal.ConsultarPorDescripcion();


                if (NombreOK == false)
                {
                    string msg = string.Format("¿Desea agregar el producto {0}?", MiProductoLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Producto guadado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaProducto();

                        }
                        else
                        {
                            MessageBox.Show("Producto no guadado correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (NombreOK)
                    {
                        MessageBox.Show("El producto con ese nombre ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }

                }




            }
        }



        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosDigitados())
            {
                MiProductoLocal.Nombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.Stock = Convert.ToInt32(TxtStock.Text.Trim());



                MiProductoLocal.MiCategoria.IdCategoria = Convert.ToInt32(CbCategoria.SelectedValue);
                MiProductoLocal.MiMarca.IdMarca = Convert.ToInt32(CbMarca.SelectedValue);
                MiProductoLocal.MiProveedor.IdProveedor = Convert.ToInt32(CbProveedor.SelectedValue);


                if (MiProductoLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar el usuario? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Modificar())
                        {
                            MessageBox.Show("El usuario se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaProducto();

                        }

                    }

                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            if (MiProductoLocal.IdProducto > 0 && MiProductoLocal.ConsultarPorID())
            {

                if (CBoxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar el producto?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiProductoLocal.Eliminar())
                        {
                            MessageBox.Show("El producto ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaProducto();

                            
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el producto?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Activar())
                        {
                            MessageBox.Show("El producto ha sido activada satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaProducto();
                        }

                    }

                }


            }

        }

        private void TxtProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void CBoxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
             CargarListaProducto();

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
            DialogResult = DialogResult.Cancel;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaProducto();
        }
    }
}