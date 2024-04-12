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

        private DataTable ListaProducto {  get; set; }
        private Logica.Models.Producto MiProductoLocal { get; set; }

        TomaFisica MiTomaFisica { get; set; }
        


        public FrmTomaFisica()
        {
            InitializeComponent();

            MiTomaFisica = new TomaFisica();

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
    }
}
