using System;
using System.Collections.Generic;
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

        public Categoria MiCategoria { get; set; }
        public Marca MiMarca { get; set; }
        public Proveedor MiProveedor { get; set; }



    }
}
