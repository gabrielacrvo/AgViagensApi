using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Model;
using DestinosApi.Database;
using Microsoft.EntityFrameworkCore;

namespace DestinosApi.Repository
{
    public class DestinoRepository : IDestinoRepository
    {

        //Injetar dependências

        private readonly DestinoDbContext _context;

        public DestinoRepository(DestinoDbContext context){
           
           _context = context;
        }
        public void addDestino(Destino destino)
        {
            _context.Add(destino);
        }

        public async Task<Destino> GetDestinoById(int id)
        {
            return await _context.Destinos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Destino>> GetDestinos()
        {
            return await _context.Destinos.ToListAsync();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }
    }
}