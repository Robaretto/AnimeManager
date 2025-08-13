namespace AnimeManager.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string Imagen { get; set; } = "naruto.jpg";
    }
}