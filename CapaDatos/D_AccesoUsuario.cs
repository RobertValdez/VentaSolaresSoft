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
    public class D_AccesoUsuario
    {
        public int D_ConcederAcceso(E_AccesoUsuario eUser)
        {

            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.SqlConex;

            SqlCommand cmd = new SqlCommand("Acceso_Usuario", strCon);

            SqlParameter Return = new SqlParameter();
            Return.ParameterName = "@Usuario";
            Return.SqlDbType = SqlDbType.VarChar;
            Return.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(Return);

            SqlParameter Usuario = new SqlParameter();
            Usuario.ParameterName = "@Usuario";
            Usuario.SqlDbType = SqlDbType.VarChar;
            Usuario.Size = 15;
            Usuario.Value = eUser.Usuario;
            cmd.Parameters.Add(Usuario);

            SqlParameter Contrasena = new SqlParameter();
            Contrasena.ParameterName = "@Contrasena";
            Contrasena.SqlDbType = SqlDbType.VarChar;
            Contrasena.Size = 15;
            Contrasena.Value = eUser.Contrasena;
            cmd.Parameters.Add(Contrasena);

            strCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            return (int)cmd.Parameters["@Usuario"].Value;
        }
    }
}
