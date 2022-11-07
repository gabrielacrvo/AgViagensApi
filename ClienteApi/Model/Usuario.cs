using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApi.Model
{
    public class Usuario
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public string Cpf {get; set;}

        public string Rua {get; set;}
        
        public string Uf {get; set;}

        public string Email {get; set;}

        public string Senha {get; set;}
    }
}