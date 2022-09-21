using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private String _NombreSucursal;
        private String _DescripcionSucursal;
        private String id_ProvinciaSucursal;
        private String _DireccionSucursal;

        public Sucursal()
        {
        }

        public string NombreSucursal { get => _NombreSucursal; set => _NombreSucursal = value; }
        public string DescripcionSucursal { get => _DescripcionSucursal; set => _DescripcionSucursal = value; }
        public string DireccionSucursal { get => _DireccionSucursal; set => _DireccionSucursal = value; }
        public string Id_ProvinciaSucursal { get => id_ProvinciaSucursal; set => id_ProvinciaSucursal = value; }
    }
}
