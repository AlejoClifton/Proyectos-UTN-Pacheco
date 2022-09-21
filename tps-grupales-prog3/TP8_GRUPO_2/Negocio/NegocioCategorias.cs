using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioCategorias
    {
        DaoSucursal dao = new DaoSucursal();
        
        public void GuardarSucursal(Sucursal suc)
        {

            dao.agregarSucursal(suc);

        }

        public DataTable ObtenerTablaProvincias()
        {
            DataTable ds = dao.ObtenerTabla("Select * from Provincia", "Provincia");
            return ds;
        }



        public DataTable ObtenerTablaSucursales()
        {
            string query = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia as Provincia, S.DireccionSucursal from Sucursal as S inner join Provincia as P on P.Id_Provincia = S.Id_ProvinciaSucursal";

            return dao.ObtenerTabla(query,"Sucursal");
        }

        public void EliminarSucursal(string idSucursal)
        {
            dao.eliminarSucursal(idSucursal);            
        }
    }

    
}
