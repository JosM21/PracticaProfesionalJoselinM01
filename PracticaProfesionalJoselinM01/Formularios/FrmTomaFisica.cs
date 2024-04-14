using Logica.Models;
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
    public partial class FrmTomaFisica : Form
    {

        public DataTable ListaProducto {  get; set; }

        public Logica.Models.Producto MiProductoLocal { get; set; }

        public  TomaFisica MiTomaFisicaLocal { get; set; }
        


        public FrmTomaFisica()
        {
            InitializeComponent();

            MiTomaFisicaLocal = new TomaFisica();

            MiProductoLocal = new Logica.Models.Producto();

            ListaProducto = new DataTable();

            CargarListaProductos();


        }

        private void FrmTomaFisica_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

        }

        private void CargarListaProductos()
        {

            ListaProducto = new DataTable();

            ListaProducto = MiProductoLocal.ListarProductos(true);

            DgLista.DataSource = ListaProducto;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        


        private void CalcularDiferencia()
        {
            if (ListaProducto != null && ListaProducto.Rows.Count>0)
            {

                foreach (DataRow item in ListaProducto.Rows)
                {
                    int number;

                    if (item != null && item["cantidad"] != null && int.TryParse(item["cantidad"].ToString(), out number))
                    {
                        int diff = 0;

                        diff = Convert.ToInt32(item["stock"]) - Convert.ToInt32(item["cantidad"]);

                        item["diferencia"] = diff;
                    }

                }

               // ListaProducto.AcceptChanges();
                        
            }
        }

        private void DgLista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            CalcularDiferencia();
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //primero se valida que se haya seleccionado un proveedor, un tipo de compra
            //y que haya como mínimo una linea en el detalle 
            if (ValidarCompra())
            {
                //los pasos para agregar un encabezado-detalle son: 
                //1. realizar insert en el encabezado y recolectar el ID recién creado, 
                //teniendo claro que ese ID se genera a nivel de base de datos. 

                //2. Con ese ID + el Id del producto tenemos las dos FK para hacer el insert en 
                //la tabla de detalle 


                //se agregan los datos de encabezado que hacen falta (de proveedor ya estaban listos) 
                MiTomaFisicaLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiTomaFisicaLocal.CompraNotas = TxtNotas.Text.Trim();

                //como estoy ingresando con un botón de ingreso rápido en el login no tengo 
                //datos en el usuario global. por lo pronto el ID será "quemado" 
                MiCompraLocal.MiUsuario.UsuarioID = 2;

                TrasladoDetalleListaVisualAObjetoCompra();

                //a este punto tenemos armado completamente el objeto de compra local. 
                //se puede proceder a la función de agregar. 

                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra creada correctamente!!", ":)", MessageBoxButtons.OK);

                    //TODO. crear un reporte de la compra. 

                    LimpiarForm();

                }

            }

        }
            private bool ValidarCompra()
            {
                bool R = false;

                if (fechaCompra.Value != DateTime.MinValue &&
                !string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                    CboxCompraTipo.SelectedIndex >= 0 &&
                    ListaProductos.Rows.Count > 0)



                {
                    R = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                    {
                        MessageBox.Show("Se debe seleccionar un proveedor", "Error de validación", MessageBoxButtons.OK);
                        return false;
                    }

                    if (CboxCompraTipo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Se debe seleccionar un tipo de compra", "Error de validación", MessageBoxButtons.OK);
                        return false;
                    }

                    if (ListaProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("Debe haber al menos una fila en el detalle", "Error de validación", MessageBoxButtons.OK);
                        return false;
                    }

                }

                return R;

            }
        
    }
}
