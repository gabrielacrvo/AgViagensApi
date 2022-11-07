using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Model;
using DestinosApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DestinosApi.Controllers
{
    public class DestinoController : ControllerBase
    {
        //Injetar dependência do repositório
        
        private readonly IDestinoRepository  _repository;

        public DestinoController(IDestinoRepository repository){
            _repository = repository;
        }
        
        
        
        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var destinos = await _repository.GetDestinos();
            return destinos.Any() ? Ok(destinos) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            var destino = await _repository.GetDestinoById(id);
            return destino != null ? Ok (destino) : NotFound ("Destino Não encontrado");
            
        }
        

        [HttpPost]
        public async Task<IActionResult>  Post(DestinoController destino){
            _repository.AddDestino(destino);
            return await _repository.SaveChangesAsync() 
            ? Ok ("Destino adicionado") : BadRequest ("Algo deu errado");
        }

        [HttpPost]
        public async Task<IActionResult>  Post(Destino destino){
            _repository.AddDestino(destino);
            return await _repository.SaveChangesAsync() 
            ? Ok ("Destino adicionado") : BadRequest ("Algo deu errado");
        }
    }
}