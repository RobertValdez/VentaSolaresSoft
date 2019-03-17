using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_BuscarCliente
    {
        public DataTable D_BuscarClientes()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarClientes", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
