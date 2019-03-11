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
    public class D_Solares
    {

        public DataTable D_MostrarSolares()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarSolares", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public string a()
        //{
        //    connection.Open();
        //    SqlCommand command1 = new SqlCommand("select imgfile from myimages where imgname=@param", connection);
        //    SqlParameter myparam = command1.Parameters.Add("@param", SqlDbType.NVarChar, 30);
        //    myparam.Value = txtimgname.Text;
        //    byte[] img = (byte[])command1.ExecuteScalar();
        //    MemoryStream str = new MemoryStream();
        //    str.Write(img, 0, img.Length);
        //    Bitmap bit = new Bitmap(str);
        //    connection.Close();
        //}

        public int InsertarSolar(E_Solares eSolar)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "InsertarSolar";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parNumeroCertTitulo = new SqlParameter();
            parNumeroCertTitulo.ParameterName = "@NumCertTitulo";  //biint
            parNumeroCertTitulo.SqlDbType = SqlDbType.Float;
            parNumeroCertTitulo.Size = 50;
            parNumeroCertTitulo.Value = eSolar.NumeroCertTitulo;
            cmd.Parameters.Add(parNumeroCertTitulo);

            SqlParameter parCantidadMetros = new SqlParameter();
            parCantidadMetros.ParameterName = "@CantidadMetros"; //Biint
            parCantidadMetros.SqlDbType = SqlDbType.Float;
            parCantidadMetros.Size = 10;
            parCantidadMetros.Value = eSolar.CantidadMetros;
            cmd.Parameters.Add(parCantidadMetros);

            SqlParameter parNumero = new SqlParameter();
            parNumero.ParameterName = "@Número";
            parNumero.SqlDbType = SqlDbType.Float;
            parNumero.Size = 5;
            parNumero.Value = eSolar.Numero;
            cmd.Parameters.Add(parNumero);

            SqlParameter parCoordenadas = new SqlParameter();
            parCoordenadas.ParameterName = "@Coordenadas"; //String
            parCoordenadas.SqlDbType = SqlDbType.VarChar;
            parCoordenadas.Size = 70;
            parCoordenadas.Value = eSolar.Coordenadas;
            cmd.Parameters.Add(parCoordenadas);

            SqlParameter parColindSolar = new SqlParameter();
            parColindSolar.ParameterName = "@ColindSolar";
            parColindSolar.SqlDbType = SqlDbType.VarChar;
            parColindSolar.Value = eSolar.ColindSolar;
            cmd.Parameters.Add(parColindSolar);
            //*No contiene Size por ser un VarChar(Max) y 
            //su contenido es extenso

            SqlParameter parDescAddPropiedad = new SqlParameter();
            parDescAddPropiedad.ParameterName = "@DescAddProp";
            parDescAddPropiedad.SqlDbType = SqlDbType.VarChar;
            parDescAddPropiedad.Value = eSolar.DescAddPropiedad;
            cmd.Parameters.Add(parDescAddPropiedad);
            //*No contiene Size por ser un VarChar(Max) y 
            //su contenido es extenso

            SqlParameter parInfoPropiedad = new SqlParameter();
            parInfoPropiedad.ParameterName = "@InfoPropietario"; //Biint
            parInfoPropiedad.SqlDbType = SqlDbType.Float;
            parInfoPropiedad.Size = 20;
            parInfoPropiedad.Value = eSolar.InfoPropietario;
            cmd.Parameters.Add(parInfoPropiedad);

            SqlParameter parImagenTitulo = new SqlParameter();
            parImagenTitulo.ParameterName = "@Imagen";
            parImagenTitulo.SqlDbType = SqlDbType.Image;
            parImagenTitulo.Value = eSolar.ImagenTitulo;
            cmd.Parameters.Add(parImagenTitulo);
            //*No contiene Size por ser un tipo image 
            //su contenido expresado en byte[] es extenso

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.VarChar;
            parPrecio.Size = 20;
            parPrecio.Value = eSolar.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.VarChar;
            parEstado.Size = 15;
            parEstado.Value = eSolar.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parFechaRegistro = new SqlParameter();
            parFechaRegistro.ParameterName = "@FechaRegistro";
            parFechaRegistro.SqlDbType = SqlDbType.Date;
            parFechaRegistro.Value = eSolar.FechaRegistro;
            cmd.Parameters.Add(parFechaRegistro);
            //*No contiene Size por ser un dato de fecha 
            //no representa mucho espacio en BD

            return cmd.ExecuteNonQuery();
        }

        public int ModificarSolar(E_Solares eSolar)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "ModificarSolar";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@Id";
            parId.SqlDbType = SqlDbType.Float;
            parId.Size = 20;
            parId.Value = eSolar.Id; 
            cmd.Parameters.Add(parId);

            SqlParameter parNumeroCertTitulo = new SqlParameter();
            parNumeroCertTitulo.ParameterName = "@NumCertTitulo";
            parNumeroCertTitulo.SqlDbType = SqlDbType.Float;
            parNumeroCertTitulo.Size = 50;
            parNumeroCertTitulo.Value = eSolar.NumeroCertTitulo;
            cmd.Parameters.Add(parNumeroCertTitulo);

            SqlParameter parCantidadMetros = new SqlParameter();
            parCantidadMetros.ParameterName = "@CantidadMetros";
            parCantidadMetros.SqlDbType = SqlDbType.Float;
            parCantidadMetros.Size = 10;
            parCantidadMetros.Value = eSolar.CantidadMetros;
            cmd.Parameters.Add(parCantidadMetros);

            SqlParameter parNumero = new SqlParameter();
            parNumero.ParameterName = "@Número";
            parNumero.SqlDbType = SqlDbType.Float;
            parNumero.Size = 5;
            parNumero.Value = eSolar.Numero;
            cmd.Parameters.Add(parNumero);

            SqlParameter parCoordenadas = new SqlParameter();
            parCoordenadas.ParameterName = "@Coordenadas";
            parCoordenadas.SqlDbType = SqlDbType.VarChar;
            parCoordenadas.Size = 70;
            parCoordenadas.Value = eSolar.Coordenadas;
            cmd.Parameters.Add(parCoordenadas);

            SqlParameter parColindSolar = new SqlParameter();
            parColindSolar.ParameterName = "@ColindSolar";
            parColindSolar.SqlDbType = SqlDbType.VarChar;
            parColindSolar.Value = eSolar.ColindSolar;
            cmd.Parameters.Add(parColindSolar);
            //*No contiene Size por ser un VarChar(Max) y 
            //su contenido es extenso

            SqlParameter parDescAddPropiedad = new SqlParameter();
            parDescAddPropiedad.ParameterName = "@DescAddProp";
            parDescAddPropiedad.SqlDbType = SqlDbType.VarChar;
            parDescAddPropiedad.Value = eSolar.DescAddPropiedad;
            cmd.Parameters.Add(parDescAddPropiedad);
            //*No contiene Size por ser un VarChar(Max) y 
            //su contenido es extenso

            SqlParameter parInfoPropiedad = new SqlParameter();
            parInfoPropiedad.ParameterName = "@InfoPropietario";
            parInfoPropiedad.SqlDbType = SqlDbType.Float;
            parInfoPropiedad.Size = 20;
            parInfoPropiedad.Value = eSolar.InfoPropietario;
            cmd.Parameters.Add(parInfoPropiedad);

            SqlParameter parImagenTitulo = new SqlParameter();
            parImagenTitulo.ParameterName = "@Imagen";
            parImagenTitulo.SqlDbType = SqlDbType.Image;
            parImagenTitulo.Value = eSolar.ImagenTitulo;
            cmd.Parameters.Add(parImagenTitulo);
            //*No contiene Size por ser un tipo image 
            //su contenido expresado en byte[] es extenso

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.VarChar;
            parPrecio.Size = 20;
            parPrecio.Value = eSolar.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.VarChar;
            parEstado.Size = 15;
            parEstado.Value = eSolar.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parFechaRegistro = new SqlParameter();
            parFechaRegistro.ParameterName = "@FechaRegistro";
            parFechaRegistro.SqlDbType = SqlDbType.Date;
            parFechaRegistro.Value = eSolar.FechaRegistro;
            cmd.Parameters.Add(parFechaRegistro);
            //*No contiene Size por ser un dato de fecha 
            //no representa mucho espacio en BD

            return cmd.ExecuteNonQuery();
        }
        public int EliminarSolar(E_Solares eSolar)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "EliminarSolar";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@Id";
            parId.SqlDbType = SqlDbType.Float;
            parId.Value = eSolar.Id;
            cmd.Parameters.Add(parId);

            return cmd.ExecuteNonQuery();
        }
    }
}
