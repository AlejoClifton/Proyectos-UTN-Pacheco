using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;

namespace TP7_GRUPO2
{
    public class TablaSesion
    {

        public static DataTable CrearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("ID_SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("DESCRIPCION", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }
        public static void AgregarFila(DataTable tabla, String[] Datos)
        {
            DataRow dr = tabla.NewRow();
            dr["ID_SUCURSAL"] = Datos[0];
            dr["NOMBRE"] = Datos[1];
            dr["DESCRIPCION"] = Datos[2];

            tabla.Rows.Add(dr);
        }

        public static void IngresarDatosEnGrilla(GridView grilla, DataTable Datos)
        {
            grilla.DataSource = Datos;
            grilla.DataBind();
        }
    }
}