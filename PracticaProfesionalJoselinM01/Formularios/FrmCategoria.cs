﻿using System;
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
    public partial class FrmCategoria : Form
    {

        private Logica.Models.Categoria MiCategoriaLocal { get; set; }
        private DataTable ListarCategoria { get; set; }



        public FrmCategoria()
        {
            InitializeComponent();

            MiCategoriaLocal = new Logica.Models.Categoria();
            ListarCategoria = new DataTable();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaCategorias();
            ActivarAgregar();
        }

        private void CargarListaCategorias()
        {
            ListarCategoria = new DataTable();


            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }



            if (CBoxVerActivos.Checked)
            {
                ListarCategoria = MiCategoriaLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListarCategoria = MiCategoriaLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListarCategoria;


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

            LimpiarFormulario();

            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdMarca = Convert.ToInt32(MiFila.Cells["CidCategoria"].Value);

                MiCategoriaLocal = new Logica.Models.Categoria();
                MiCategoriaLocal.IdCategoria = IdMarca;
                MiCategoriaLocal = MiCategoriaLocal.ConsultarPorIDRetornaCategoria();

                if (MiCategoriaLocal != null && MiCategoriaLocal.IdCategoria > 0)
                {

                    TxtCategoriaID.Text = Convert.ToString(MiCategoriaLocal.IdCategoria);
                    TxtDescripcion.Text = MiCategoriaLocal.DescripcionCategoria;


                    ActivarEditarEliminar();


                }

            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DgLista.ClearSelection();
            LimpiarFormulario();
            ActivarAgregar();

        }

        private void LimpiarFormulario()
        {
            TxtCategoriaID.Clear();
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

                    MessageBox.Show("Debe digitar un categora valida", "Error de validacion", MessageBoxButtons.OK);
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


                MiCategoriaLocal = new Logica.Models.Categoria();



                MiCategoriaLocal.DescripcionCategoria = TxtDescripcion.Text.Trim();



                NombreOK = MiCategoriaLocal.ConsultarPorDescripcion();

                if (NombreOK == false)
                {
                    string msg = string.Format("¿Desea agregar la categoria {0}?", MiCategoriaLocal.DescripcionCategoria);

                    DialogResult respuesta = MessageBox.Show(msg, "?", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiCategoriaLocal.Agregar();

                        if (ok)
                        {

                            MessageBox.Show("Categoria guadada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCategorias();

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
                        MessageBox.Show("La categoria con ese nombre ya existe", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }

                }

            }
        }



        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiCategoriaLocal.DescripcionCategoria = TxtDescripcion.Text.Trim();
    

                if (MiCategoriaLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("Desea modificar la categoria? ", ":/", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiCategoriaLocal.Modificar())
                        {
                            MessageBox.Show("La categoria se modifico correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaCategorias   ();

                        }

                    }

                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiCategoriaLocal.IdCategoria > 0 && MiCategoriaLocal.ConsultarPorID())
            {

                if (CBoxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Desea eliminar la categoria?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {

                        if (MiCategoriaLocal.Eliminar())
                        {
                            MessageBox.Show("La categoria ha sido eliminado correctamente !", "!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaCategorias();
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar la categoria?", "???", MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiCategoriaLocal.Activar())
                        {
                            MessageBox.Show("La categoria ha sido activada satisfactoriamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaCategorias();
                        }

                    }

                }


            }

        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void CBoxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaCategorias();

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
            CargarListaCategorias();
        }
    }
}
