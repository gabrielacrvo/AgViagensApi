using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Model;

namespace DestinosApi.Repository
{
    public interface IDestinoRepository
    {
        Task<IEnumerable<Destino>> GetDestinos();

        Task<Destino> GetDestinoById(int id);

        void addDestino(Destino destino);

        Task<bool> SaveChangeAsync();
    }
}