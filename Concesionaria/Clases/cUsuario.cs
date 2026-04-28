using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Concesionaria.Clases
{
    public class cUsuario
    {
        public DataTable GetUsuario(string USUARIO, string CLAVE)
        {
            string sql = "select *";
            sql = sql + " from Usuario";
            sql = sql + " Where Nombre=" + "'" + USUARIO.ToString() + "'";
            sql = sql + " AND Clave=" + "'" + CLAVE + "'";
            return cDb.ExecuteDataTable(sql);
        }

        public string GetNombreUsuarioxCodUsuario(Int32 CodUsuario)
        {
            string user ="";
            string sql = "select * from Usuario";
            sql = sql + " where CodUsuario=" +CodUsuario.ToString ();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count > 0)
                user = trdo.Rows[0]["Nombre"].ToString();
            return user;
        }

        public DataTable GetRol()
        {
            cFunciones fun = new Clases.cFunciones();
            string Col = "CodRol;Nombre";
            DataTable tb = fun.CrearTabla(Col);
            string val = "";
            val = "1;Administrado";
            tb = fun.AgregarFilas(tb, val);
            val = "2;Vendedor";
            tb = fun.AgregarFilas(tb, val);
            return tb;
        }

        public bool Buscar(string Nombre)
        {
            bool Op = false;
            string sql = "select * from usuario ";
            sql = sql + " where Nombre =" + "'" + Nombre + "'";
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count >0)
            {
                if (trdo.Rows[0]["Nombre"].ToString ()!="")
                {
                    Op = true;
                }
            }
            return Op;
        }

        public void ActualizarClave(int CoidUsuario, string Clave)
        {
            string sql = "Update usuario ";
            sql = sql + " set Clave =" + "'" + Clave + "'";
            sql = sql + " where CodUsuario =" + CoidUsuario.ToString();
            cDb.ExecutarNonQuery(sql);
        }
    }
}
