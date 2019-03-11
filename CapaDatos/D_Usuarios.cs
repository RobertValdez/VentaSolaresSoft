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
    public class D_Usuarios
    {
        public string D_ComprobarCed(E_Usuarios eUser)
        {
            SqlConnection strCon = new SqlConnection();
            DataTable dt = new DataTable();
            strCon.ConnectionString = Conexion.SqlConex;

            SqlCommand cmd = new SqlCommand("UsComprobar_CedulaEmpl", strCon);

            SqlParameter Return = new SqlParameter();
            Return.ParameterName = "@Cedula";
            Return.SqlDbType = SqlDbType.VarChar;
            Return.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(Return);

            SqlParameter Comprobar = new SqlParameter();
            Comprobar.ParameterName = "@Cedula";
            Comprobar.SqlDbType = SqlDbType.VarChar;
            Comprobar.Size = 20;
            Comprobar.Value = eUser.ComprobarCedula;
            cmd.Parameters.Add(Comprobar);

            strCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            string rsp = Convert.ToString(cmd.Parameters["@Cedula"].Value);
            return rsp;
        }

        public string D_ComprobarNombreUser(E_Usuarios eUser)
        {
            SqlConnection strCon = new SqlConnection();
            DataTable dt = new DataTable();
            strCon.ConnectionString = Conexion.SqlConex;

            SqlCommand cmd = new SqlCommand("UsComprobar_NombreUser", strCon);
            
            SqlParameter Return = new SqlParameter();
            Return.ParameterName = "@NomUser";
            Return.SqlDbType = SqlDbType.VarChar;
            Return.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(Return);

            SqlParameter Comprobar = new SqlParameter();
            Comprobar.ParameterName = "@NomUser";
            Comprobar.SqlDbType = SqlDbType.VarChar;
            Comprobar.Size = 20;
            
            Comprobar.Value = eUser.ComprobarNomUser;
            cmd.Parameters.Add(Comprobar);

            strCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            string rsp = Convert.ToString(cmd.Parameters["@NomUser"].Value);
            return rsp;
        }
    }
}
