using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorEmail { get; set; }
        public string ProveedorDireccion { get; set; }
        public string ProveedorNotas { get; set; }
        public bool Activo { get; set; }

        //propiedades, atributo compuestas
        public TipoProveedor MiTipoProveedor { get; set; }
        public Proveedor()
        {
            MiTipoProveedor = new TipoProveedor { };
        }

        public bool Agregar()
        {
            bool R = false;

            Services.Conexion MiCnn = new Services.Conexion();

           
            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProveedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.ProveedorEmail));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.ProveedorNotas));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProveedorDireccion));

           
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdTipo", this.MiTipoProveedor.ProveedorTipo));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");

            
            if (resultado > 0)
            {
                R = true;
            }



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

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

       
            Services.Conexion MiCnn = new Services.Conexion();

         
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", pCedula));

            DataTable Consulta = new DataTable();
           
            Consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarPorCedula");


          
            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail(string pEmail)
        {
            bool R = false;

           
            Services.Conexion MiCnn = new Services.Conexion();

            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pEmail));

            DataTable Consulta = new DataTable();
         
            Consulta = MiCnn.EjecutarSELECT("SPProveedorConsultarPorEmail");


           
            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }
        public bool ConsultarPorID(int pid)
        {
            bool R = false;


            return R;
        }

        public DataTable Listar(bool VerActivos = true, string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Services.Conexion MIcnn = new Services.Conexion();

            MIcnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MIcnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MIcnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }
        //public TipoProveedor MiTipoProveedor;

        

    }
}
