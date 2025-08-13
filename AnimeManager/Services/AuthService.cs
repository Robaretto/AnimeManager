using AnimeManager.Models;

namespace AnimeManager.Services
{
    public class AuthService
    {
        private Usuario? usuarioLogueado;

        // Simula login. Podés personalizarlo con un usuario "real"
        public bool Login(string email, string nombre)
        {
            // Podés agregar validación más real si querés
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(nombre))
            {
                usuarioLogueado = new Usuario
                {
                    Id = 1,
                    Nombre = nombre,
                    Email = email,
                    Imagen = "default.jpg"
                };
                return true;
            }
            return false;
        }

        public Usuario? ObtenerUsuarioLogueado() => usuarioLogueado;

        public void Logout() => usuarioLogueado = null;
    }
}