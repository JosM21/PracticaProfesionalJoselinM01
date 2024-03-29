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
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPCategoriaListarCombo");

            return R;


        }


        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPCategoriaListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPCategoriaListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdCategoria));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Categoria ConsultarPorIDRetornaCategoria()
        {
            Categoria R = new Categoria();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdCategoria));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.IdCategoria = Convert.ToInt32(dr["idCategoria"]);
                R.DescripcionCategoria = Convert.ToString(dr["descripcionCategoria"]);



            }


            return R;
        }

        public bool ConsultarPorDescripcion()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionCategoria));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorNombre");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionCategoria));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaAgregar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.DescripcionCategoria));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@idCategoria", this.IdCategoria));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaModificar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdCategoria));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaDesactivar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdCategoria));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaActivar");

            if (respuesta > 0)
            {
                R = true;
            }



            return R;

        }


    }
}
