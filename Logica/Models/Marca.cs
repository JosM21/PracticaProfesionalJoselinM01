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
    public class Marca
    {
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPMarcaListarCombo");

            return R;

        }


        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPMarcaListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPMarcaListar");

            return R;

        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdMarca));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPMarcaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Marca ConsultarPorIDRetornaMarca()
        {
            Marca R = new Marca();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdMarca));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPMarcaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.IdMarca = Convert.ToInt32(dr["idMarca"]);
                R.DescripcionMarca = Convert.ToString(dr["descripcionMarca"]);



            }


            return R;
        }



        public bool ConsultarPorDescripcion()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionMarca));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPMarcaConsultarPorNombre");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionMarca));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPMarcaAgregar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionMarca));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@idMarca", this.IdMarca));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPMarcaModificar");


            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdMarca));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPMarcaDesactivar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdMarca));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPMarcaActivar");

            if (respuesta > 0)
            {
                R = true;
            }



            return R;

        }


    }
}