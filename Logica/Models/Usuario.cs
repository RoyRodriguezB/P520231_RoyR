using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string UsuarioCorreo { get; set; }

        public string UsuarioContrasennia { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioCedula { get; set; }
        public string UsuarioTelefono { get; set; }
        public string UsuarioDireccion { get; set; }

        public bool Activo { get; set; }

        //propiedades, atributo compuestas
        public Usuario_Rol MiRolTipo { get; set; }

        //constructor
        public Usuario()
        {
            MiRolTipo = new Usuario_Rol { };
        }
        //funciones y metodos
        public bool Agregar()
        {
            bool R = false;
            // aca va el codigo funcional que  invoca a procedimiento almacenado

            //paso 1.6.1 y 1.6.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //encriptar la contraseña
            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.UsuarioContrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));

            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));

            //normalmente foreign key tienen q ver con composiciones, extraer el valor objeto compuesto "MiRolTipo"
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolID));

            //pasos 1.6.3 y 1-6-4
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");

            //paso 1.6.5
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            //paso  
            Services.Conexion MiCnn = new Services.Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            //encriptar la contraseña
            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.UsuarioContrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));

            //normalmente foreign key tienen q ver con composiciones, extraer el valor objeto compuesto "MiRolTipo"
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));
            //pasos 
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");

            //paso 
            if (resultado > 0)
            {
                R = true;
            }


            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            Services.Conexion MiCnn = new Services.Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

            if (respuesta > 0)
            {
                R = true;
            }


            return R;
        }

        public bool Activar()
        {
            //TAREA CREAR LA funcionalidad para activar un usuario
            //incluso este proceso, el SP y la implementacion en el UI
            //es lo inverso de eliminar

            bool R = false;

            Services.Conexion MiCnn = new Services.Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

            if (respuesta > 1)
            {
                R = true;
            }


            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;

            Services.Conexion MiCnn = new Services.Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new  Usuario();
            Services.Conexion  MiCnn = new Services.Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["UsuarioNombre"]);

                R.UsuarioCedula = Convert.ToString(dr["UsuarioCedula"]);
                R.UsuarioCorreo = Convert.ToString(dr["UsuarioCorreo"]);
                R.UsuarioTelefono = Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);

                R.UsuarioContrasennia = string.Empty;

                //composiciones
                R.MiRolTipo.UsuarioRolID = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion"]);

            }
           
            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            //paso 1.3.1 y 1.3.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //se deben agregar los params si el SP los requiere
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));

            DataTable Consulta = new DataTable();
            //paso 1.3.3 y 1.3.4
             Consulta = MiCnn.EjecutarSELECT("SpUsuarioConsultarPorCedula");


            //paso 1.3.5
            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //paso 1.4.1 y 1.4.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //se deben agregar los params si el SP los requiere
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));

            DataTable Consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            Consulta = MiCnn.EjecutarSELECT("SpUsuarioConsultarPorEmail");


            //paso 1.4.5
            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();


            //paso 2.1 y 2.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //paso 2.3 y 2.4
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SpUsuarioListar");

            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();


            //paso 2.1 y 2.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //paso 2.3 y 2.4
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SpUsuarioListar");

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasennia)
        {
            Usuario R = new Usuario();

            return R;
        }

    }
}
