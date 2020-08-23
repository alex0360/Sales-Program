namespace Negocios
{
    public class Usuario
    {
        public static bool VerificarUsuario(string usuario, string clave)
        {
            Datos.Usuario login = new Datos.Usuario();

            return login.ValidarUsuario(usuario, clave);
        }
    }
}
