using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinosApi.Repository;
using Microsoft.AspNetCore.Mvc;
using DestinosApi.Model;

namespace DestinosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinoController : ControllerBase
    {
        //Injetar dp do repositório

        private readonly IDestinoRepository _repository;

        public DestinoController(IDestinoRepository repository){
            _repository = repository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll (){
            var destinos =await _repository.GetDestinos();
            return destinos.Any() ? Ok(destinos) : NoContent();

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id){
            var destino = await _repository.GetDestinoById(id);
            return destino != null ? Ok (destino) : NotFound ("Destino não encontrado");

        }

        [HttpPost]

        public async Task<IActionResult> Post (Destino destino){
            _repository.addDestino (destino);
            return await _repository.SaveChangeAsync()
            ? Ok ("Destino adicionado") : BadRequest ("Algo deu errado");
        }
    }
}