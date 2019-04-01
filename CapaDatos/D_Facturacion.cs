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
        public DataTable MostrarCompraPendiente()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("Mostrar_Compra_Pendiente", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int InsertarCompra(E_Facturacion eFact)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "InsertarCompra";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parCed_Solar = new SqlParameter();
            parCed_Solar.ParameterName = "@Ced_Solar";
            parCed_Solar.SqlDbType = SqlDbType.Int;
            parCed_Solar.Value = eFact.Ced_Solar;
            cmd.Parameters.Add(parCed_Solar);

            SqlParameter parCliente = new SqlParameter();
            parCliente.ParameterName = "@Cliente";
            parCliente.SqlDbType = SqlDbType.Int;
            parCliente.Size = 10;
            parCliente.Value = eFact.Cliente;
            cmd.Parameters.Add(parCliente);

            SqlParameter parVendedor = new SqlParameter();
            parVendedor.ParameterName = "@Vendedor";
            parVendedor.SqlDbType = SqlDbType.Int;
            parVendedor.Size = 10;
            parVendedor.Value = eFact.Vendedor;
            cmd.Parameters.Add(parVendedor);

            SqlParameter parInicial = new SqlParameter();
            parInicial.ParameterName = "@Inicial";
            parInicial.SqlDbType = SqlDbType.Int;
            parInicial.Size = 10;
            parInicial.Value = eFact.Inicial;
            cmd.Parameters.Add(parInicial);

            SqlParameter parSubTotal = new SqlParameter();
            parSubTotal.ParameterName = "@SubTotal";
            parSubTotal.SqlDbType = SqlDbType.Int;
            parSubTotal.Size = 10;
            parSubTotal.Value = eFact.SubTotal;
            cmd.Parameters.Add(parSubTotal);

            SqlParameter parDescuento = new SqlParameter();
            parDescuento.ParameterName = "@Descuento";
            parDescuento.SqlDbType = SqlDbType.Int;
            parDescuento.Size = 10;
            parDescuento.Value = eFact.Descuento;
            cmd.Parameters.Add(parDescuento);

            SqlParameter parTotal = new SqlParameter();
            parTotal.ParameterName = "@Total";
            parTotal.SqlDbType = SqlDbType.Int;
            parTotal.Size = 10;
            parTotal.Value = eFact.Total;
            cmd.Parameters.Add(parTotal);

            SqlParameter parCuotas = new SqlParameter();
            parCuotas.ParameterName = "@Cuotas";
            parCuotas.SqlDbType = SqlDbType.Int;
            parCuotas.Size = 10;
            parCuotas.Value = eFact.Cuotas;
            cmd.Parameters.Add(parCuotas);

            SqlParameter parNotario = new SqlParameter();
            parNotario.ParameterName = "@Notario";
            parNotario.SqlDbType = SqlDbType.Int;
            parNotario.Size = 10;
            parNotario.Value = eFact.Notario;
            cmd.Parameters.Add(parNotario);

            SqlParameter parAbogado = new SqlParameter();
            parAbogado.ParameterName = "@Abogado";
            parAbogado.SqlDbType = SqlDbType.VarChar;
            parAbogado.Size = 50;
            parAbogado.Value = eFact.Abogado;
            cmd.Parameters.Add(parAbogado);

            SqlParameter parFecha = new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Size = 10;
            parFecha.Value = eFact.Fecha;
            cmd.Parameters.Add(parFecha);

            return cmd.ExecuteNonQuery();
        }
    }
}
