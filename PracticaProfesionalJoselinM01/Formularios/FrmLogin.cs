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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;   

        }



        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO"){
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;

            }

        }


        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == ""){
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;
            }

        }


        private void TxtContrasennia_Enter(object sender, EventArgs e)
        {
            if (TxtContrasennia.Text == "CONTRASEÑA"){
                TxtContrasennia.Text = "";
                TxtContrasennia.ForeColor = Color.LightGray;
                TxtContrasennia.UseSystemPasswordChar = true;

            }


        }

        private void TxtContrasennia_Leave(object sender, EventArgs e)
        {
            if (TxtContrasennia.Text =="") {
                TxtContrasennia.Text = "CONTRASEÑA";
                TxtContrasennia.ForeColor= Color.DimGray;
                TxtContrasennia.UseSystemPasswordChar = false;


            }
            

        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {

            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
