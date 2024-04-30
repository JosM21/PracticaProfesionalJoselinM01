using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasennia { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }


        public UsuarioRol MiRolTipo { get; set; }


        public Usuario()
        {

            MiRolTipo = new UsuarioRol();
        }


        public bool Agregar()
        {

            bool R = false;


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", Email));

            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);


            MiCnn.ListaDeParametros.Add(new SqlParameter("@contrasennia", ContrasenniaEncriptada));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@direccion", this.Direccion));


            //composiciones
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idRol", this.MiRolTipo.IdUsuarioRol));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");


            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Modificar()
        {

            bool R = false;


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", this.Email));

            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);

            MiCnn.ListaDeParametros.Add(new SqlParameter("@contrasennia", ContrasenniaEncriptada));

            

            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@direccion", this.Direccion));


            //composiciones
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idRol", this.MiRolTipo.IdUsuarioRol));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@idUsuario", this.IdUsuario));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");


            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }
        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdUsuario));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdUsuario));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);

                R.Contrasennia = string.Empty;

                //        //composiciones
                R.MiRolTipo.IdUsuarioRol = Convert.ToInt32(dr["idUsuarioRol"]);
                R.MiRolTipo.TipoUsuarioRol = Convert.ToString(dr["descripcionRol"]);

            }


            return R;
        }


        public bool ConsultarPorCedula()
        {
            bool R = false;


            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;


            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", this.Email));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPUsuarioListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPUsuarioListar");

            return R;
        }


        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdUsuario));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

            if (respuesta > 0)
            {

                R = true;

            }


            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdUsuario));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

            if (respuesta > 0)
            {
                R = true;
            }



            return R;

        }

        public Usuario ValidarUsuario(string pEmail, string pContrasenia)
        {

            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            Crypto crypto = new Crypto();
            string ContrasenniaEncriptada = crypto.EncriptarEnUnSentido(pContrasenia);



            MiCnn.ListaDeParametros.Add(new SqlParameter("@usuario", pEmail));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@password", ContrasenniaEncriptada));




            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioValidarIngreso");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);
                R.Contrasennia = string.Empty;

                      //composiciones
                R.MiRolTipo.IdUsuarioRol = Convert.ToInt32(dr["idUsuarioRol"]);
                R.MiRolTipo.TipoUsuarioRol = Convert.ToString(dr["descripcionRol"]);

            }

            return R;
        }


        public bool ValidarCodigoVerificacion(string pUsuario, string pCodigoVerificacion)
        {
            bool R = false;

            this.Email = pUsuario;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Usuario", this.Email));

            DataTable Respuesta = MiCnn.EjecutarSELECT("SPUsuarioObtenerCodigoRecuperacion");

            if (Respuesta != null && Respuesta.Rows.Count > 0)
            {
                DataRow MiFila = Respuesta.Rows[0];

                string CodigoDB = Convert.ToString(MiFila["codigo"]);

                //Se compara el codigo almacenado en la tabla contra el código tipeado en el formulario (que llegó acá por param)
                if (CodigoDB == pCodigoVerificacion)
                {
                    R = true;
                }
            }
            return R;
        }

        public bool GuardarCodigoRecuperacionContrasennia(string CodigoRecuperacion)
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegarán al SP
                MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));
                MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoRecuperacion", CodigoRecuperacion));

                int retorno = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioGuardarCodigoRecuperacion");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }

        public bool EditarPassword()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegarán al SP

                MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

                Crypto MiEncriptador = new Crypto();
                string PasswordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasennia))
                {
                    PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
                }

                MiCnn.ListaDeParametros.Add(new SqlParameter("@Pass", PasswordEncriptado));

                int retorno = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioEditarPassword");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }


    }
}





    

