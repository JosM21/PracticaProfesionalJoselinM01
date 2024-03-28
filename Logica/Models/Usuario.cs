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
        public string BackUpEmail { get; set; }
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
            //Crypto MiEncriptador = new Crypto();
            //string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@contrasennia", this.Contrasennia));
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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@contrasennia", this.Contrasennia));

            //Crypto MiEncriptador = new Crypto();
            //string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);

            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@direccion", this.Direccion));


            //composiciones
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idRol", this.MiRolTipo.IdUsuarioRol));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@idUsuario",this.IdUsuario));


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

            public DataTable ListarActivos()
            {
                DataTable R = new DataTable();

                Conexion MiCnn = new Conexion();


                MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
                //MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

                R = MiCnn.EjecutarSELECT("SPUsuarioListar");

                return R;
            }

            public DataTable ListarInactivos()
            {
                DataTable R = new DataTable();
                Conexion MiCnn = new Conexion();

                MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
                // MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


                R = MiCnn.EjecutarSELECT("SPUsuarioListar");

                return R;
            }




    }
} 






    

