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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormUsuarios.Visible) 
            {
                Globales.MiFormUsuarios = new FrmUsuario();
                Globales.MiFormUsuarios.Show();
            
            }
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormProducto.Visible)
            {
                Globales.MiFormProducto = new FrmProducto();
                Globales.MiFormProducto.Show();

            }

        }

        private void ProovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormProveedor.Visible)
            {
                Globales.MiFormProveedor = new FrmProveedor();
                Globales.MiFormProveedor.Show();

            }

        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormCategoria.Visible)
            {
                Globales.MiFormCategoria = new FrmCategoria();
                Globales.MiFormCategoria.Show();

            }


        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormMarca.Visible)
            {
                Globales.MiFormMarca = new FrmMarca();
                Globales.MiFormMarca.Show();

            }


        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            string InfoUsuario = string.Format("{0}-{1} ({2})", Globales.MiUsuarioGlobal.Nombre,
                                                                Globales.MiUsuarioGlobal.Email,
                                                                Globales.MiUsuarioGlobal.MiRolTipo.TipoUsuarioRol);
            LblUsuario.Text = InfoUsuario;



            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiRolTipo.IdUsuarioRol)
            {
                case 1:
                    break;
                case 2:
                    usuariosToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;

                    break;
            }
        }

        private void tomaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormTomaFisica.Visible)
            {
                Globales.MiFormTomaFisica = new FrmTomaFisica();
                Globales.MiFormTomaFisica.Show();

            }

        }
    }
}
