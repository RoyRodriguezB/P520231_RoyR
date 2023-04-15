using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_RoyR
{
    public class Globales
    {
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();
        //obtener un obj de tipo Usuario q permita almacenar los datos de usuario, que se haya logueado
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();

    }
}
