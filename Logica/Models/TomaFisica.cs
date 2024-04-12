using System;
using System.Collections.Generic;
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

        public List<TomaFisicaDetalle> ListaDetalles {  get; set; }

        public TomaFisica()
        {
            MiUsuario = new Usuario();
            ListaDetalles = new List<TomaFisicaDetalle>();

        }
    }
}
