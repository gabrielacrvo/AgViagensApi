using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApi.Model;

namespace ClienteApi.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();

        Task<Usuario> GetUsuarioById(int id);

        void AddUsuario(Usuario usuario);

         

        Task<bool> SaveChangesAsync();
    }
}