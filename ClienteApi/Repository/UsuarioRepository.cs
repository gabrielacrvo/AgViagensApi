using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApi.Database;
using ClienteApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ClienteApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        
        //Injetar Dependências

        private readonly UsuarioDbContext _context;

        public UsuarioRepository(UsuarioDbContext context){
            _context = context;
        }

        public void AddUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }


        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            return await  _context.Usuarios.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }
    }
}