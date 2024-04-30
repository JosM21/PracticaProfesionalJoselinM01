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
    public partial class FrmRecuperacionContrasennia : Form
    {

        public bool CorreoEnviado { get; set; }

        public Email MiEmail { get; set; }

        public Usuario MiUsuario { get; set; }
        public FrmRecuperacionContrasennia()
        {
            InitializeComponent();
            CorreoEnviado = false;

            MiEmail = new Logica.Models.Email();

            MiUsuario = new Logica.Models.Usuario();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnviarCodigo_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) && Herramientas.ValidarEmail(TxtUsuario.Text.Trim()))
            {
                string CodigoParaEnviar = "ABC123$%&";

                //TODO PARTE DE EXAMEN: Hacer una Función que genere aleatoriamente un código de recuperación con 
                //la siguiente complejidad: 
                //1. Que tenga un tamaño exacto de 9 digitos
                //2. Debe contener 3 letras, 3 números y 3 caracteres especiales (!"$%&/=....)

                MiUsuario.Email = TxtUsuario.Text.Trim();

                if (MiUsuario.ConsultarPorEmail())
                {
                    if (MiUsuario.GuardarCodigoRecuperacionContrasennia(CodigoParaEnviar))
                    {

                        //Procedemos a enviar el mismo código de verificación al correo del usuario
                        //Si el valor del código almacenado en la tabla es el mismo que el código que el usuario 
                        //recibe en el email y que digita en el cuadro de texto; se le permite cambiar la contraseña.

                        Logica.Models.Email MiCorreo = new Logica.Models.Email();

                        MiCorreo.Asunto = "CODIGO DE RECUPERACION DE CONTRASEÑA SISTEMA DE COMPRAS PROGRA 5";

                        MiCorreo.CorreoDestino = TxtUsuario.Text.Trim();

                        string Mensaje = string.Format("Su código de recuperación de contraseña es: {0}", CodigoParaEnviar);

                        MiCorreo.Mensaje = Mensaje;

                        if (MiCorreo.EnviarCorreo_Net_Mail_SmtpClient())
                        {
                            MessageBox.Show("Correo enviado con éxito!", ":)", MessageBoxButtons.OK);

                            TxtCodigoVerificacion.Enabled = true;
                            TxtPassword1.Enabled = true;
                            TxtPassword2.Enabled = true;

                        }

                    }

                }
                else
                {
                    MessageBox.Show("El email no existe!", "Error de validación de datos", MessageBoxButtons.OK);
                }

            }


        }

        private void TxtCodigoVerificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRecuperacionContrasennia_Load(object sender, EventArgs e)
        {
            TxtCodigoVerificacion.Enabled = false;
            TxtPassword1.Enabled = false;
            TxtPassword2.Enabled = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                //Se debe comprobar que los códigos de validación sean identicos, y si lo son se procede a guardar la contraseña encriptada
                MiUsuario.Email = TxtUsuario.Text.Trim();

                MiUsuario.Contrasennia = TxtPassword1.Text.Trim();

                if (MiUsuario.ValidarCodigoVerificacion(TxtUsuario.Text.Trim(), TxtCodigoVerificacion.Text.Trim()))
                {
                    //procedemos a cambiar la contraseña

                    if (MiUsuario.EditarPassword())
                    {

                        MessageBox.Show("Contraseña actualiza con éxito!!", ":)", MessageBoxButtons.OK);
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Codigo de verificación es incorrecto", ":(", MessageBoxButtons.OK);
                    TxtCodigoVerificacion.Focus();
                    TxtCodigoVerificacion.SelectAll();
                }

            }

          
        }

        private bool ValidarCampos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCodigoVerificacion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPassword1.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPassword2.Text.Trim()) &&
                TxtPassword1.Text.Trim() == TxtPassword2.Text.Trim())
            {
                R = true;
            }

            return R;

        }
    }
}
