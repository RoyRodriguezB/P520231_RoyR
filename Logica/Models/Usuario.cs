﻿using System;
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

            return R;
        }

        public bool Editar()
        {
            bool R = false;
           
            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;


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


            return R;
        }

        public bool ConsultarPorCedulaEmail()
        {
            bool R = false;


            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();


            //paso 2.1 y 2.2 
            Services.Conexion MiCnn = new Services.Conexion();

            //paso 2.3 y 2.4
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            R = MiCnn.EjecutarSELECT("SpUsuarioListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasennia)
        {
            Usuario R = new Usuario();

            return R;
        }

    }
}