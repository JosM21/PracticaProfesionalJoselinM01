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
    public partial class FrmMarca : Form
    {


        private Logica.Models.Marca MiMarcaLocal { get; set; }
        private DataTable ListarMarca { get; set; }


        public FrmMarca()
        {
            InitializeComponent();

            MiMarcaLocal = new Logica.Models.Marca();
            ListarMarca = new DataTable();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaMarcas();
            ActivarAgregar();
        }

        private void CargarListaMarcas()
        {
            ListarMarca = new DataTable();

            if (CBoxVerActivos.Checked)
            {
                ListarMarca = MiMarcaLocal.ListarActivos();
            }
            else
            {
                ListarMarca = MiMarcaLocal.ListarInactivos();
            }

            DgLista.DataSource = ListarMarca;


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


                int IdMarca = Convert.ToInt32(MiFila.Cells["CidMarca"].Value);

                MiMarcaLocal = new Logica.Models.Marca();
                MiMarcaLocal.IdMarca = IdMarca;
                MiMarcaLocal = MiMarcaLocal.ConsultarPorIDRetornaMarca();

                if (MiMarcaLocal != null && MiMarcaLocal.IdMarca > 0)
                {

                    TtxtMarcaID.Text = Convert.ToString(MiMarcaLocal.IdMarca);
                    TxtDescripcion.Text = MiMarcaLocal.DescripcionMarca;


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
            TtxtMarcaID.Clear();
            TxtDescripcion.Clear();

        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;


            if (!string.IsNullOrEmpty(TxtDescripcion.Text.Trim())
                )
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar una marca valida", "Error de validacion", MessageBoxButtons.OK);
                    TxtDescripcion.Focus();
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


                MiMarcaLocal = new Logica.Models.Marca();



                MiMarcaLocal.DescripcionMarca = TxtDescripcion.Text.Trim();



                NombreOK = MiMarcaLocal.ConsultarPorDescripcion();

                if (NombreOK == false)
                {
                    string msg = string.Format("¿Desea agregar la marca {0}?", MiMarcaLocal.DescripcionMarca);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiMarcaLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Marca guadada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaMarcas();

                        }
                        else
                        {
                            MessageBox.Show("Categoria no guadada correctamente!", ":(", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    if (NombreOK)
                    {
                        MessageBox.Show("La marca con ese nombre ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }

                }

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiMarcaLocal.DescripcionMarca = TxtDescripcion.Text.Trim();


                if (MiMarcaLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar la marca? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiMarcaLocal.Modificar())
                        {
                            MessageBox.Show("La marca se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaMarcas();

                        }

                    }

                }
            }
        }




    }
}
