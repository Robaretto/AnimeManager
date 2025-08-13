using AnimeManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimeManager.Services
{
    public class AnimeService
    {
        private List<Anime> animes = new List<Anime>
        {
            new Anime { Id = 1, Titulo = "Naruto", Genero = "Acción", Anio = 2002, Imagen = "naruto.png" },
            new Anime { Id = 2, Titulo = "One Piece", Genero = "Aventura", Anio = 1999, Imagen = "onepiece.png" },
            new Anime { Id = 3, Titulo = "Attack on Titan", Genero = "Drama", Anio = 2013, Imagen = "attackontitan.png" },
            new Anime { Id = 4, Titulo = "Death Note", Genero = "Suspenso", Anio = 2006, Imagen = "deathnote.png" },
            new Anime { Id = 5, Titulo = "Fullmetal Alchemist", Genero = "Aventura", Anio = 2003, Imagen = "fullmetal.png" },
            new Anime { Id = 6, Titulo = "Demon Slayer", Genero = "Acción", Anio = 2019, Imagen = "demonslayer.png" },
            new Anime { Id = 7, Titulo = "Jujutsu Kaisen", Genero = "Sobrenatural", Anio = 2020, Imagen = "jujutsu.png" },
            new Anime { Id = 8, Titulo = "My Hero Academia", Genero = "Superhéroes", Anio = 2016, Imagen = "heroacademia.png" },
            new Anime { Id = 9, Titulo = "Tokyo Ghoul", Genero = "Terror", Anio = 2014, Imagen = "tokyoghoul.png" },
            new Anime { Id = 10, Titulo = "Bleach", Genero = "Acción", Anio = 2004, Imagen = "bleach.png" }
        };

        public List<Anime> GetAll() => animes;

        public Anime? GetById(int id) => animes.FirstOrDefault(a => a.Id == id);

        public void Add(Anime anime)
        {
            anime.Id = animes.Any() ? animes.Max(a => a.Id) + 1 : 1;
            animes.Add(anime);
        }

        public void Update(Anime anime)
        {
            var existing = GetById(anime.Id);
            if (existing is not null)
            {
                existing.Titulo = anime.Titulo;
                existing.Genero = anime.Genero;
                existing.Anio = anime.Anio;
                existing.Imagen = anime.Imagen;
            }
        }

        public void Delete(int id)
        {
            var anime = GetById(id);
            if (anime is not null)
                animes.Remove(anime);
        }
    }
}