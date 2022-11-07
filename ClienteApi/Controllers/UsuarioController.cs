using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApi.Model;
using ClienteApi.Repository;
using Microsoft.AspNetCore.Mvc;


namespace ClienteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController :ControllerBase
    {
       
        //Injetar dependência do repositório
        
        private readonly IUsuarioRepository  _repository;

        public UsuarioController(IUsuarioRepository repository){
            _repository = repository;
        }
        
        
        
        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var usuarios = await _repository.GetUsuarios();
            return usuarios.Any() ? Ok(usuarios) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            var usuario = await _repository.GetUsuarioById(id);
            return usuario != null ? Ok (usuario) : NotFound ("Usuário Não encontrado");
            
        }
        

        [HttpPost]
        public async Task<IActionResult>  Post(Usuario usuario){
            _repository.AddUsuario(usuario);
            return await _repository.SaveChangesAsync() 
            ? Ok ("Usuário adicionado") : BadRequest ("Algo deu errado");
        }

        [HttpPost]
        public async Task<IActionResult>  Post(Usuario usuario){
            _repository.AddUsuario(usuario);
            return await _repository.SaveChangesAsync() 
            ? Ok ("Usuário adicionado") : BadRequest ("Algo deu errado");
        }

        
    }
}