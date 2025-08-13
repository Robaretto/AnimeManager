namespace AnimeManager.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Imagen { get; set; } = "default.png"; // debe estar en wwwroot/images/usuarios/
    }
}