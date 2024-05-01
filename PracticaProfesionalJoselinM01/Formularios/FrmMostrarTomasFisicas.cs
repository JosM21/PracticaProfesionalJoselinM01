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
    public partial class FrmMostrarTomasFisicas : Form
    {
        public FrmMostrarTomasFisicas()
        {
            InitializeComponent();
        }

        private void FrmMostrarTomasFisicas_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
        }

        private void CrystalReport11_InitReport(object sender, EventArgs e)
        {

        }
    }
}
