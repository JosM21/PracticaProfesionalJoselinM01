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
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        //composicion 

        public Categoria MiCategoria { get; set; }
        public Marca MiMarca { get; set; }
        public Proveedor MiProveedor { get; set; }

        public Producto()
        {
            MiCategoria = new Categoria();
            MiMarca = new Marca();
            MiProveedor = new Proveedor();  
        }

        public DataTable ListarProductos(bool verActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            R = MiCnn.EjecutarSELECT("SPTomaFisicaDetalleListar");

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProductoListar");

            return R;
        }


        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = MiCnn.EjecutarSELECT("SPProductoListar");

            return R;
        }


        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProducto));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Producto ConsultarPorIDRetornaProducto()
        {
            Producto R = new Producto();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProducto));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.IdProducto = Convert.ToInt32(dr["idProducto"]);
                R.Nombre = Convert.ToString(dr["nombreProducto"]);
             

                //        //composiciones
                R.MiCategoria.IdCategoria = Convert.ToInt32(dr["idCategoria"]);
                R.MiCategoria.DescripcionCategoria = Convert.ToString(dr["descripcionCategoria"]);


                R.MiMarca.IdMarca = Convert.ToInt32(dr["idMarca"]);
                R.MiMarca.DescripcionMarca = Convert.ToString(dr["descripcionMarca"]);


                R.MiProveedor.IdProveedor = Convert.ToInt32(dr["idProveedor"]);
                R.MiProveedor.Nombre = Convert.ToString(dr["nombreProveedor"]);


            }


            return R;
        }


        public bool ConsultarPorDescripcion()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Nombre));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorNombre");

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

            //composiciones
            MiCnn.ListaDeParametros.Add(new SqlParameter("@categoria", this.MiCategoria.IdCategoria));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@marca", this.MiMarca.IdMarca));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@proveedor", this.MiProveedor.IdProveedor));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoAgregar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@idProducto", this.IdProducto));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Nombre));
        

            //composiciones
            MiCnn.ListaDeParametros.Add(new SqlParameter("@categoria", this.MiCategoria.IdCategoria));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@marca", this.MiMarca.IdMarca));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@proveedor", this.MiProveedor.IdProveedor));




            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoModificar");


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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProducto));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoDesactivar");

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdProducto));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoActivar");

            if (respuesta > 0)
            {
                R = true;
            }



            return R;

        }




    }




}
