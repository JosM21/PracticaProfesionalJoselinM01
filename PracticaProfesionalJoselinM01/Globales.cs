
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace PracticaProfesionalJoselinM01
{
    public static class Globales
    {

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuario MiFormUsuarios = new Formularios.FrmUsuario();

        public static Formularios.FrmProducto MiFormProducto = new Formularios.FrmProducto();

        public static Formularios.FrmProveedor MiFormProveedor = new Formularios.FrmProveedor();

        public static Formularios.FrmCategoria MiFormCategoria = new Formularios.FrmCategoria();

        public static Formularios.FrmMarca MiFormMarca = new Formularios.FrmMarca();

        public static Formularios.FrmTomaFisica MiFormTomaFisica = new Formularios.FrmTomaFisica();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario(); 

        
    }
}
