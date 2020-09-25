using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos {
    public class Cliente {
        private SqlDataReader sqlDataReader;
        bool existe = false;
        public DataSet Mostrar() {
            try {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_CLIENTESLoadAll", Conexion.SqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.Fill(dataSet, "VerRecord");

                return dataSet;
            } catch(Exception ex) {
                MessageBox.Show("Hay problemas: " + ex.Message, "al Listar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            } finally { if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close(); }
        }

        public bool ValidarRecord(int id) {
            SqlCommand sqlCommand;
            using(sqlCommand = new SqlCommand()) {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.Connection = Conexion.SqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "proc_CLIENTESLoadByPrimaryKey";

                int i = 0;
                try {
                    sqlCommand.Parameters.AddWithValue("@IdCliente", id);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    while(sqlDataReader.Read() == true) {
                        i++;
                    }
                    if(i >= 1) { existe = true; } else { existe = false; }
                } catch(Exception) {
                    existe = false;
                } finally {
                    if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
                }
                return existe;
            }
        }

        public DataSet BuscarRecord(string parametro) {
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter AdaptadorSQL = new SqlDataAdapter();
            try {
                DataSet dataSet = new DataSet();

                sqlCommand = new SqlCommand(parametro, Conexion.SqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@parametro", parametro);

                AdaptadorSQL.SelectCommand = sqlCommand;
                AdaptadorSQL.Fill(dataSet, "VerRecord");

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                return dataSet;
            } catch(Exception) {
                throw;
            } finally { if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close(); }

        }

        public void Registrar(Entidades.Cliente cliente) {
            try {
                SqlCommand sqlCommand = new SqlCommand("proc_CLIENTESInsert", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@NombCliente", cliente.NombreCliente);
                sqlCommand.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                sqlCommand.Parameters.AddWithValue("@Pais", cliente.Pais);
                sqlCommand.Parameters.AddWithValue("@SaldoInic", cliente.SaldoInicial);
                sqlCommand.Parameters.AddWithValue("@SaldoAct", cliente.SaldoActual);
                sqlCommand.Parameters.AddWithValue("@Estatus", cliente.Estatus);

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }

        }

        public void Actualizar(Entidades.Cliente cliente) {
            try {
                SqlCommand sqlCommand = new SqlCommand("proc_CLIENTESUpdate", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                sqlCommand.Parameters.AddWithValue("@NombCliente", cliente.NombreCliente);
                sqlCommand.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                sqlCommand.Parameters.AddWithValue("@Pais", cliente.Pais);
                sqlCommand.Parameters.AddWithValue("@SaldoInic", cliente.SaldoInicial);
                sqlCommand.Parameters.AddWithValue("@SaldoAct", cliente.SaldoActual);
                sqlCommand.Parameters.AddWithValue("@Estatus", cliente.Estatus);

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

            } catch(Exception ex) {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public void Inhabilitar(Entidades.Cliente cliente) {

            try {

                SqlCommand sqlCommand = new SqlCommand("proc_InhabilitarCLIENTESUpdate", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                sqlCommand.Parameters.AddWithValue("@Estatus", cliente.Estatus);

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

            } catch(Exception ex) {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public bool Eliminar(int id) {
            bool sequito = false;
            try {
                SqlCommand sqlCommand = new SqlCommand("proc_CLIENTESDelete", Conexion.SqlConnection);
                sqlCommand.CommandTimeout = 20;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@IdCliente", id);

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                sequito = true;
                return sequito;
            } catch(Exception ex) {
                MessageBox.Show("No se pudo Escribir " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return sequito;
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public DataTable Buscar(int valor) {
            try {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("proc_CLIENTESLoadByPrimaryKey", Conexion.SqlConnection);

                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();

                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdCliente", valor);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            } catch(Exception ex) {
                MessageBox.Show("Hay problemas: " + ex.Message, "Listar elementos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
        }

        public bool InsertarEditar(int id, string nombre, string direccion, string pais, float saldoInic, float saldoAct, bool estatus) {
            try {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand("proc_CLIENTESInsertUpdate", Conexion.SqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //sqlCmd.Parameters.AddWithValue("@Name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                //sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(dgvRow.Cells["cbxPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxPosition"].Value.ToString()));
                //sqlCmd.Parameters.AddWithValue("@Office", dgvRow.Cells["txtOffice"].Value == DBNull.Value ? "" : dgvRow.Cells["txtOffice"].Value.ToString());
                //sqlCmd.Parameters.AddWithValue("@Age", Convert.ToInt32(dgvRow.Cells["txtAge"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtAge"].Value.ToString()));
                //sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                return true;
            } catch { return false; } finally { }

        }

        public DataTable MostrarBuscar(string textBuscar) {
            DataTable tableResutado = new DataTable();
            try {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand() {
                    Connection = Conexion.SqlConnection,
                    CommandText = "proc_CLIENTES_NOMBRE",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter ParTextBuscar = new SqlParameter() {
                    ParameterName = "@textBuscar",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50,
                    Value = textBuscar
                }; sqlCommand.Parameters.Add(ParTextBuscar);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(tableResutado);
            } catch {
                tableResutado = null;
            } finally {
                if(Conexion.SqlConnection.State == System.Data.ConnectionState.Open) Conexion.SqlConnection.Close();
            }
            return tableResutado;
        }
    }
}
