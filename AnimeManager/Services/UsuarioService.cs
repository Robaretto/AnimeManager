using AnimeManager.Models;

namespace AnimeManager.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new();

        private int nextId = 1;

        public List<Usuario> ObtenerUsuarios() => usuarios;

        public void AgregarUsuario(Usuario usuario)
        {
            usuario.Id = nextId++;
            usuarios.Add(usuario);
        }

        public void EditarUsuario(Usuario usuarioEditado)
        {
            var index = usuarios.FindIndex(u => u.Id == usuarioEditado.Id);
            if (index != -1)
                usuarios[index] = usuarioEditado;
        }

        public void EliminarUsuario(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
                usuarios.Remove(usuario);
        }
    }
}