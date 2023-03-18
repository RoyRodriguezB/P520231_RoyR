using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        //se digitan las propiedades de la clase
        public int UsuarioRolID { get; set; }
        public string UsuarioRolDescripcion { get; set; }

        //escribir propiedades simples y 
        //propiedades compuestas

        //se escriben las funciones y metodos.

        public DataTable Listar()
        {
            DataTable R = new DataTable();
            //darle funcionalidad
            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;

        }

    }
}
