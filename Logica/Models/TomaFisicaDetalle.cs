using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TomaFisicaDetalle
    {
        public int Cantidad {  get; set; }
        public int Nombre { get; set; }

        //composicion

        public Producto MiProducto { get; set; }


        public TomaFisicaDetalle()
        {
            MiProducto = new Producto();
        }



    }
}
