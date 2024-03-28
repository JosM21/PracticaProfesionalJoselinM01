using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Services;

namespace Logica.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPProveedorListarCombo");

            return R;


        }


        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            //MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            // MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProveedor));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Proveedor ConsultarPorIDRetornaProveedor()
        {
            Proveedor R = new Proveedor();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProveedor));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.IdProveedor = Convert.ToInt32(dr["idProveedor"]);
                R.Nombre = Convert.ToString(dr["nombreProveedor"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["telefono"]);
                R.Direccion = Convert.ToString(dr["direccion"]);




            }


            return R;
        }

        public bool ConsultarPorDescripcion()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.Nombre));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProveedorConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }


        public bool Agregar()
        {

            bool R = false;


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", this.Email));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");


            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }



        //public bool Editar()
        //{
        //    bool R = false;

        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));

        //    //Encriptar la contraseña
        //    Crypto MiEncriptador = new Crypto();
        //    string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));


        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

        //    //normalmente los foreign keys tienen que ver con composiciones, en este caso 
        //    //tenemos que extraer el valor del objeto compuesto 'MiRolTipo'
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.IDRol));

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IDUsuario));

        //    int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");

        //    if (resultado > 0)
        //    {
        //        R = true;
        //    }

        //    return R;
        //}

        //public bool Eliminar()
        //{
        //    bool R = false;

        //    //Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IDUsuario));

        //    int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

        //    if (respuesta > 0)
        //    {
        //        R = true;
        //    }

        //    return R;
        //}

        //public bool Activar()
        //{
        //    bool R = false;


        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IDUsuario));

        //    int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

        //    if (respuesta > 0)
        //    {
        //        R = true;
        //    }
        //    return R;
        //}








    }
}
