using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Concesionaria.Clases
{
    public static  class cColor
    {
        public static System.Drawing.Color CajaTexto()
        {
            return System.Drawing.Color.LightGreen;
        }

        public static string GetColorxId(int CodColor)
        {
            string sql = "select * from Color where CodColor=" + CodColor.ToString();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            string Nombre = "";
            if (trdo.Rows.Count >0)
            {
                Nombre = trdo.Rows[0]["Nombre"].ToString(); 
            }
            return Nombre;
        }
    }
}
