﻿using System;
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
        //       R = true;
        //    }

        //    return R;
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

        //public Usuario ConsultarPorIDRetornaUsuario()
        //{
        //    Usuario R = new Usuario();

        //    Conexion MiCnn = new Conexion();

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IDUsuario));

        //    //necesito un datatable para capturar la info del usuario 
        //    DataTable dt = new DataTable();

        //    dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        //esta consulta debería tener solo un registro, 
        //        //se crea un objeto de tipo datarow para capturar la info 
        //        //contenida en index 0 del dt (datatable)
        //        DataRow dr = dt.Rows[0];

        //        R.IDUsuario = Convert.ToInt32(dr["IDUsuario"]);
        //        R.Nombre = Convert.ToString(dr["Nombre"]);

        //        R.Cedula = Convert.ToString(dr["Cedula"]);
        //        R.Correo = Convert.ToString(dr["Correo"]);
        //        R.Telefono = Convert.ToString(dr["Telefono"]);
        //        R.Direccion = Convert.ToString(dr["Direccion"]);

        //        R.Contrasennia = string.Empty;

        //        //composiciones
        //        R.MiRolTipo.IDRol = Convert.ToInt32(dr["IDRol"]);
        //        R.MiRolTipo.Descripcion = Convert.ToString(dr["Descripcion"]);

        //    }


        //    return R;
        //}


        //public bool ConsultarPorCedula()
        //{
        //    bool R = false;

        //    //paso 1.3.1 y 1.3.2
        //    Conexion MiCnn = new Conexion();

        //    //agregamos el parametro de cedula 
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

        //    DataTable consulta = new DataTable();
        //    //paso 1.3.3 y 1.3.4
        //    consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");

        //    //paso 1.3.5
        //    if (consulta != null && consulta.Rows.Count > 0)
        //    {
        //        R = true;
        //    }

        //    return R;
        //}

        //public bool ConsultarPorEmail()
        //{
        //    bool R = false;

        //    //paso 1.4.1 y 1.4.2
        //    Conexion MiCnn = new Conexion();

        //    //agregamos el parametro de correo 
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));

        //    DataTable consulta = new DataTable();
        //    //paso 1.4.3 y 1.4.4
        //    consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorEmail");

        //    //paso 1.4.5
        //    if (consulta != null && consulta.Rows.Count > 0)
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
        //}

        //public Usuario ValidarUsuario(string pEmail, string pContrasennia)
        //{
        //    Usuario R = new Usuario();

        //    Conexion MiCnn = new Conexion();

        //    Crypto crypto = new Crypto();
        //    string ContrasenniaEncriptada = crypto.EncriptarEnUnSentido(pContrasennia);

        //    MiCnn.ListaDeParametros.Add(new SqlParameter("usuario", pEmail));
        //    MiCnn.ListaDeParametros.Add(new SqlParameter("password", ContrasenniaEncriptada));

        //    //necesito un datatable para capturar la info del usuario 
        //    DataTable dt = new DataTable();

        //    dt = MiCnn.EjecutarSELECT("SPUsuarioValidarIngreso");

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        //esta consulta debería tener solo un registro, 
        //        //se crea un objeto de tipo datarow para capturar la info 
        //        //contenida en index 0 del dt (datatable)
        //        DataRow dr = dt.Rows[0];

        //        R.IDUsuario = Convert.ToInt32(dr["IDUsuario"]);
        //        R.Nombre = Convert.ToString(dr["Nombre"]);
        //        R.Cedula = Convert.ToString(dr["Cedula"]);
        //        R.Correo = Convert.ToString(dr["Correo"]);
        //        R.Telefono = Convert.ToString(dr["Telefono"]);
        //        R.Direccion = Convert.ToString(dr["Direccion"]);

        //        R.Contrasennia = string.Empty;

        //        //composiciones
        //        R.MiRolTipo.IDRol = Convert.ToInt32(dr["IDRol"]);
        //        R.MiRolTipo.Descripcion = Convert.ToString(dr["Descripcion"]);

        //    }


        //    return R;
        //}

    }
}






    

