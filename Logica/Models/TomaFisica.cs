using CrystalDecisions.CrystalReports.Engine;
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
    public class TomaFisica
    {

        public int IdTomaFisica { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }
        public bool Active { get; set; }


        //compociciones simples

        public Usuario MiUsuario { get; set; }

        //compociciones complejas

        public List<TomaFisicaDetalle> ListaDetalles { get; set; }

        public TomaFisica()
        {
            MiUsuario = new Usuario();
            ListaDetalles = new List<TomaFisicaDetalle>();

        }

        public ReportDocument Imprimir (ReportDocument document)
        {
          
            ReportDocument R = document;

            CrystalReport Objcrystal = new CrystalReport(R);

            DataTable Dt = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.IdTomaFisica));



            Dt = MiCnn.EjecutarSELECT("SPTomaFisicaReporte");

            if (Dt != null && Dt.Rows.Count > 0)
            {
                Objcrystal.dt = Dt;

                R = Objcrystal.GenerarReporte();
            }
            

            return R;

            

        }



        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //lista de parametros 
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.Notas));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdUsuario", this.MiUsuario.IdUsuario));

           
            Object retorno = MiCnn.EjecutarSELECTEscalar("SPTomaFisicaAgregar");

            //como la devolución puede ser cualquier tipo (string, int, decimal, etc) 
            //se captura la respuesta en un Object y luego se hace la conversión al tipo correcto 
            //en este caso es un int

            int IDCreada;

            if (retorno != null)
            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                    this.IdTomaFisica = IDCreada;

                    //hasta este punto se puede asegurar que el insert en el encabezado salió
                    //correctamente 
                    //se procede con los insert en el detalle 

                    foreach (TomaFisicaDetalle item in this.ListaDetalles)
                    {
                        Conexion MiCnnDetalle = new Conexion();

                        //lista de parámetros del sp de insert a detalle 
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IdTomaFisica", IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IdProducto", item.MiProducto.IdProducto));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.CantidadFisica));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@StockAnterior", item.StockAnterior));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@diferencia", item.Diferencia));


                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPTomaFisicaDetalleAgregar");

                    }

                    R = true;

                }
                catch (Exception)
                {

                    throw;
                }


            }



            return R;

        }


    }

}