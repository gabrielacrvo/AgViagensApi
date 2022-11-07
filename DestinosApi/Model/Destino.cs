using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestinosApi.Model
{
    public class Destino
    {
        public int Id {get; set;}

        public string Cidade {get; set;}

        public string Uf {get; set;}

        public double Valor {get; set;}
    }
}