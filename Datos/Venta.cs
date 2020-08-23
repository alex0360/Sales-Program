using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Venta
    {
        public void InsertarVentas(Entidades.Venta entidad)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("proc_VentasInsert", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@factura", entidad.Factura);
                sqlCommand.Parameters.AddWithValue("@FECHA", entidad.Fecha);
                sqlCommand.Parameters.AddWithValue("@ID_CLIENTE", entidad.IdCliente);
                sqlCommand.Parameters.AddWithValue("@ID_VENDEDOR", entidad.IdVendedor);
                sqlCommand.Parameters.AddWithValue("@ID_PROD", entidad.IdProduccto);
                sqlCommand.Parameters.AddWithValue("@CANTIDAD", entidad.Cantidad);

                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }

        }

        public DataSet ObtenerVentas()
        {
            try
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_CLIENTESLoadAll", Conexion.SqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.Fill(dataSet, "VerRecord");

                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas: " + ex.Message, "al Listar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally { if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close(); }
        }

        public void RebajarConceptos(Entidades.Venta entidad)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("proc_VentasRebajar", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID_PROD", entidad.IdProduccto);
                sqlCommand.Parameters.AddWithValue("@CANTIDAD", entidad.Cantidad);


                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public DataSet ObtenerVentasClientes()
        {
            try
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_VentasObtener", Conexion.SqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.Fill(dataSet, "VerRecord");

                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas: " + ex.Message, "al Listar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally { if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close(); }
        }

        //proc_VentasObtenerFactura
        public DataTable MostrarBuscar(string textBuscar)
        {
            DataTable tableResutado = new DataTable();
            try
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand()
                {
                    Connection = Conexion.SqlConnection,
                    CommandText = "proc_VentasObtenerFactura",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter()
                {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            }
            catch
            {
                tableResutado = null;
            }
            finally
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
            return tableResutado;
        }
    }
}

