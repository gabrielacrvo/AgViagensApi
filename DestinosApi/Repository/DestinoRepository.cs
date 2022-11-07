using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Controllers;
using DestinosApi.Database;
using DestinosApi.Model;
using Microsoft.EntityFrameworkCore;

namespace DestinosApi.Repository
{
    public class DestinoRepository : IDestinoRepository
    {
        
        private readonly DestinoDbContext _context;

        public DestinoRepository(DestinoDbContext context){
            _context = context;
        }

        public void AddDestino(Destinos destino)
        {
            _context.Add(destino);
        }


        public async Task<Destinos> GetDestinoById(int id)
        {
            return await _context.Destinos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Destinos>> GetDestinos()
        {
            return await  _context.Destinos.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }

       
}
}