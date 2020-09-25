namespace Datos {
    public class Conexion {
        public static System.Data.SqlClient.SqlConnection SqlConnection = Trigger();

        private static System.Data.SqlClient.SqlConnection Trigger() {
            //SqlConnection =Properties.Settings.Default.ConntionStringDta;
            SqlConnection =
                new System.Data.SqlClient.SqlConnection
                    (System.Configuration.ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.Conexion"].ToString());

            return SqlConnection;
        }
        ~Conexion() { if(SqlConnection.State == System.Data.ConnectionState.Open) SqlConnection.Close(); }
    }
}
