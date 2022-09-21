using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_6
{
    public class Producto
    {
        private int id_producto;
        private String Nombre_Producto;
        private String Cantidad_Por_Unidad;
        private double Precio_Unidad;

        public Producto()
        {
        }

        public Producto(int idproducto, String NombreProducto, String CantidadPorUnidad, double PrecioUnidad)
        {
            this.id_producto = idproducto;
            this.Nombre_Producto = NombreProducto;
            this.Cantidad_Por_Unidad = CantidadPorUnidad;
            this.Precio_Unidad = PrecioUnidad;
        }

        public int IdProducto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public String NombreProducto
        {
            get { return Nombre_Producto; }
            set { Nombre_Producto = value; }
        }
        public String CantidadPorUnidad
        {
            get { return Cantidad_Por_Unidad; }
            set { Cantidad_Por_Unidad = value; }
        }
        public double PrecioUnidad
        {
            get { return Precio_Unidad; }
            set { Precio_Unidad = value; }
        }
    }
}