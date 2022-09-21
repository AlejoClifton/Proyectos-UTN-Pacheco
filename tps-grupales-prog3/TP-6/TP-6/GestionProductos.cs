using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP_6
{
    public class GestionProductos
    {

        public bool ActualizarProducto(Producto prod)
        {
            
            string query = "UPDATE Productos SET NombreProducto = '"+prod.NombreProducto+"', CantidadPorUnidad = '"+prod.CantidadPorUnidad+"',PrecioUnidad = "+prod.PrecioUnidad+" WHERE IdProducto = " + prod.IdProducto;
            
           
            Conexion ad = new Conexion();
            int FilasInsertadas = ad.ejecutarConsulta(query);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public bool EliminarProducto(Producto prod)
        {
            string query = "DELETE FROM Productos WHERE IdProducto = " + prod.IdProducto;

            
            Conexion ad = new Conexion();
            int FilasInsertadas = ad.ejecutarConsulta(query);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }

   

}