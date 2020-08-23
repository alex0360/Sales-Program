using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Fabricante
    {
        public string TextBuscar { get; set; }

        public DataSet Mostrar()
        {
            try
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_FABRICANTESLoadAll", Conexion.SqlConnection);
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

        public DataSet BuscarRecord(string parametro)
        {
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            try
            {
                DataSet dataSet = new DataSet();

                sqlCommand = new SqlCommand(parametro, Conexion.SqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@parametro", parametro);

                AdaptadorSQL.SelectCommand = sqlCommand;
                AdaptadorSQL.Fill(dataSet, "VerRecord");

                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                return dataSet;
            }
            catch (Exception)
            {
                throw;
            }
            finally { if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close(); }

        }

        private SqlDataReader sqlDataReader;
        bool existe = false;
        public bool ValidarRecord(int id)
        {
            SqlCommand sqlCommand;
            using (sqlCommand = new SqlCommand())
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.Connection = Conexion.SqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "proc_FABRICANTESLoadByPrimaryKey";

                int i = 0;
                try
                {
                    sqlCommand.Parameters.AddWithValue("@IdFabricante", id);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read() == true)
                    {
                        i++;
                    }
                    if (i >= 1) { existe = true; }
                    else { existe = false; }
                }
                catch (Exception)
                {
                    existe = false;
                }
                finally
                {
                    if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
                }
                return existe;
            }
        }

        public void Registrar(Entidades.Fabricante fabricante)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("proc_FABRICANTESInsert", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@NombFabricante", fabricante.NombreFabricante);
                sqlCommand.Parameters.AddWithValue("@Direccion", fabricante.Direccion);
                sqlCommand.Parameters.AddWithValue("@Pais", fabricante.Pais);

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

        public void Actualizar(Entidades.Fabricante fabricante)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("proc_FABRICANTESUpdate", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdFabricante", fabricante.IdFabricante);
                sqlCommand.Parameters.AddWithValue("@NombFabricant", fabricante.NombreFabricante);
                sqlCommand.Parameters.AddWithValue("@Direccion", fabricante.Direccion);
                sqlCommand.Parameters.AddWithValue("@Pais", fabricante.Pais);

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

        public bool Eliminar(int id)
        {
            bool sequito = false;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("proc_FABRICANTESDelete", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdFabricante", id);

                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                sequito = true;
                return sequito;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return sequito;
            }
            finally
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public DataTable Buscar(int valor)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_FABRICANTESLoadByPrimaryKey", Conexion.SqlConnection);

                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdFabricante", valor);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar elementos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            finally
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public DataTable Mostrar_ID_RazonSocial(Fabricante fabricante)
        {
            DataTable tableResutado = new DataTable("Fabricante");
            try
            {
                if (Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand()
                {
                    Connection = Conexion.SqlConnection,
                    CommandText = "proc_FABRICANTE_NOMBRE",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter()
                {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = fabricante.TextBuscar
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
