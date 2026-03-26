using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Concesionaria.Clases
{
    public class cVentaxCliente
    {
        public void Insertar(SqlConnection con, SqlTransaction Transaccion, Int32 CodVenta, Int32 CodCliente)
        {
            string sql = "insert into VentaxCliente(CodVenta,CodCliente)";
            sql = sql + " values(" + CodVenta.ToString();
            sql = sql + "," + CodCliente.ToString();
            sql = sql + ")";
            cDb.EjecutarNonQueryTransaccion(con, Transaccion, sql);
        }

        public DataTable GetClientexCodVenta(int CodVenta)
        {
            string sql = "select c.CodCliente,c.Apellido,c.Nombre, c.NroDocumento,c.Telefono ";
            sql = sql + " from cliente c,Ventaxcliente v ";
            sql = sql + " where c.CodCliente = v.CodCliente ";
            sql = sql + " and v.CodVenta =" + CodVenta.ToString();
            return cDb.ExecuteDataTable(sql);
        }
    }
}
