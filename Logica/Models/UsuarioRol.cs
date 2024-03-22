using System.Data;

namespace Logica.Models
{
    public class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public string TipoUsuarioRol { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;

        }


    }


}
