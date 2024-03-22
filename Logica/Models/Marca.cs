using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;

        }


        //public bool Agregar()
        //{

        //    bool R = false;


        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));

        //    Crypto MiEncriptador = new Crypto();
        //    string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.IDRol));


        //    int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");


        //    if (resultado > 0)
        //    {
        //        R = true;

        //    }

        //        return R;
        //    }

        //}

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

        //public bool ConsultarPorID()
        //{
        //    bool R = false;

        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IDUsuario));

        //    //necesito un datatable para capturar la info del usuario 
        //    DataTable dt = new DataTable();

        //    dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        R = true;
        //    }

        //    return R;
        //}


        //public DataTable ListarActivos(string pFiltroBusqueda)
        //{
        //    DataTable R = new DataTable();

        //    Conexion MiCnn = new Conexion();

        //    //en este caso como el SP tiene un parámetro, debemos por lo tanto definir ese parámetro 
        //    //en la lista de parámetros del objeto de conexion 
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

        //    R = MiCnn.EjecutarSELECT("SPUsuarioListar");

        //    return R;
        //}

        //public DataTable ListarInactivos(string pFiltroBusqueda)
        //{
        //    DataTable R = new DataTable();
        //    Conexion MiCnn = new Conexion();

        //    //en este caso como el SP tiene un parámetro, debemos por lo tanto definir ese parámetro 
        //    //en la lista de parámetros del objeto de conexion 
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


        //    R = MiCnn.EjecutarSELECT("SPUsuarioListar");

        //    return R;

        }

    
}
