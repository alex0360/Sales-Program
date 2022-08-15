using System;
using System.IO;

namespace Datos
{
    public class Conexion
    {
        public static System.Data.SqlClient.SqlConnection SqlConnection = Trigger();

        private static System.Data.SqlClient.SqlConnection Trigger()
        {
            var connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.Combine(Environment.CurrentDirectory, "BD_VENTAS_020.mdf")};Integrated Security=True";

            SqlConnection =
                new System.Data.SqlClient.SqlConnection
                    (connectionString);

            return SqlConnection;
        }

        ~Conexion()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
    }
}
