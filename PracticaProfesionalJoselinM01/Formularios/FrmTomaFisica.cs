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
            if (ValidarAgregar())
            {
                //los pasos para agregar un encabezado-detalle son: 
                //1. realizar insert en el encabezado y recolectar el ID recién creado, 
                //teniendo claro que ese ID se genera a nivel de base de datos. 

                //2. Con ese ID + el Id del producto tenemos las dos FK para hacer el insert en 
                //la tabla de detalle 


                //se agregan los datos de encabezado que hacen falta (de proveedor ya estaban listos) 
                MiTomaFisicaLocal.Fecha = fechaCompra.Value;
                MiTomaFisicaLocal.Notas = TxtNotas.Text.Trim();

                //como estoy ingresando con un botón de ingreso rápido en el login no tengo 
                //datos en el usuario global. por lo pronto el ID será "quemado" 
                MiTomaFisicaLocal.MiUsuario.IdUsuario = 1;

                Traslado();

                //a este punto tenemos armado completamente el objeto de compra local. 
                //se puede proceder a la función de agregar. 

                if (MiTomaFisicaLocal.Agregar())
                {
                    MessageBox.Show("Inventario actualizado correctamente!!", ":)", MessageBoxButtons.OK);

                    //TODO. crear un reporte de la compra. 

                    LimpiarForm();

                }

            }

        }

        private void Traslado()
        {
            //pasamos los datos del datatable que se usa graficamente a la List<> del objeto
            //MiCompraLocal 
            foreach (DataRow fila in ListaProducto.Rows)
            {
                TomaFisicaDetalle nuevodetalle = new TomaFisicaDetalle();

                nuevodetalle.MiProducto.IdProducto = Convert.ToInt32(fila["idProducto"]);
                nuevodetalle.StockAnterior = Convert.ToInt32(fila["stock"]);
                nuevodetalle.CantidadFisica = Convert.ToInt32(fila["cantidad"]);
                nuevodetalle.Diferencia = Convert.ToInt32(fila["diferencia"]);


                //una vez tenemos los datos en el nuevodetalle se agrega ese objeto a la lista
                //de detalles de la compra local 
                MiTomaFisicaLocal.ListaDetalles.Add(nuevodetalle);



            }
        }

      

        private bool ValoresValidos()
        {
            foreach (DataGridViewRow row in DgLista.Rows)
            {
                object valorCelda = row.Cells["Ccantidad"].Value;
                if (valorCelda == null || !int.TryParse(valorCelda.ToString(), out _))
                {
                    return false;
                }
            }
            return true;
        }


        private void LimpiarForm()
        {
            TxtNotas.Clear();
            
       


            ListaProducto = new DataTable();

            DgLista.DataSource = ListaProducto;


        }


        private bool ValidarAgregar()
            {
                bool R = false;

            if (ValoresValidos())
                
            {
                R = true;
            }
            else
            {

                if (ValoresValidos())
                {
                    MessageBox.Show("Todos los valores en la columna 'Cantidad' deben ser enteros válidos", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }


            }

                return R;

        }
        
    }
}
