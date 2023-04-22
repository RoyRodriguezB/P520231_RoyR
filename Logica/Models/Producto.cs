using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public String ProductoNombre { get; set; }
        public String ProductoCodigoBarras { get; set; }
        public decimal CantidadStock { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public bool Activo { get; set; }



        public bool Agregar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Editar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Eliminar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool ConsultarPorCodigoDeBarras(ref string codigoBarras)
        {
            throw new System.Exception("Not implemented");
        }
        public DataTable ListarActivos()
        {
            throw new System.Exception("Not implemented");
        }
        public DataTable ListarInactivos()
        {
            throw new System.Exception("Not implemented");
        }




        public  CategoriaProducto Micategoria { get; set; }

        public Producto()
        {
            Micategoria = new CategoriaProducto();
        }
    }
}
