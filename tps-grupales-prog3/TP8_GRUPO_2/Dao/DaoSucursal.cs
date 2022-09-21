using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();
        
        public void agregarSucursal(Sucursal suc)
        {
            string agregarSucursal = "insert into sucursal(NombreSucursal, DescripcionSucursal, id_ProvinciaSucursal, DireccionSucursal) Values ('" + suc.NombreSucursal + "','" + suc.DescripcionSucursal + "','" + suc.Id_ProvinciaSucursal + "','" + suc.DireccionSucursal + "')";
            SqlConnection conexion = ds.ObtenerConexion();
            ds.ejecutarConsulta(agregarSucursal, conexion);
        }


        public DataTable ObtenerTabla(string consulta, string tabla)
        {
            SqlConnection conexion = ds.ObtenerConexion();
            return ds.ObtenerTabla(consulta,tabla,conexion);
        }

        public void eliminarSucursal(string idSucursal)
        {
            SqlConnection conexion = ds.ObtenerConexion();
            string query = "delete from sucursal where Id_Sucursal=" + idSucursal;
            ds.ejecutarConsulta(query, conexion);
        }


    }
}
