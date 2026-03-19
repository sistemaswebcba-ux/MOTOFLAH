using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Concesionaria.Clases
{
    public class cModelo
    {
        public string GetNombreModelo(int CodModelo)
        {
            string Nombre = "";
            string sql = "select * from modelo where CodModelo=" + CodModelo.ToString();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count >0)
            {
                Nombre = trdo.Rows[0]["Nombre"].ToString(); 
            }
            return Nombre;

        }

        public DataTable GetModelosxMarca(int CodMarca)
        {
            string sql = "select * from Modelo ";
            sql = sql + " where CodMarca =" + CodMarca.ToString();
            return cDb.ExecuteDataTable(sql);
        }
    }
}
