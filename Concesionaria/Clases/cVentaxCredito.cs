using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Concesionaria.Clases
{
    public class cVentaxCredito
    {
        public DataTable GetCreditoxCodVenta(Int32 CodVenta)
        {
            string sql = "select v.CodBanco, b.Nombre ,v.Importe from VentaxCredito v, Banco b";
            sql = sql + " where v.CodBanco = b.CodBanco ";
            sql = sql + " and v.CodVenta=" + CodVenta.ToString();
            return cDb.ExecuteDataTable(sql);
        }
    }
}
