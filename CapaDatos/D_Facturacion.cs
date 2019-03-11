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
    public class D_Facturacion
    {
        public int InsertarCompra(E_Facturacion eFact)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "InsertarCompra";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdSolar = new SqlParameter();
            parIdSolar.ParameterName = "@IdSolar"; 
            parIdSolar.SqlDbType = SqlDbType.Int;
            parIdSolar.Size = 10;
            parIdSolar.Value = eFact.IdSolar;
            cmd.Parameters.Add(parIdSolar);

            return cmd.ExecuteNonQuery();
        }
    }
}
