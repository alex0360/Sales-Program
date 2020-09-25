using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class Usuario {

        public bool ValidarUsuario(string usuario, string clave) {
            SqlDataReader sqlDataReader;
            using(SqlCommand sqlCommand = new SqlCommand("Usp_ValidarUsuario", Conexion.SqlConnection)) {
                try {
                    if(Conexion.SqlConnection.State == System.Data.ConnectionState.Closed) Conexion.SqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@usuario", usuario);
                    sqlCommand.Parameters.AddWithValue("@clave", clave);

                    sqlDataReader = sqlCommand.ExecuteReader();

                    if(sqlDataReader.Read()) {
                        return true;
                    }

                    return false;
                } catch(Exception ex) {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "ERROR DE CONEXION");
                    System.Windows.Forms.Application.Exit();
                    return false;
                } finally {
                    //sqlDataReader.Close();
                    sqlCommand.Connection.Close();
                }
            }
        }
    }
}