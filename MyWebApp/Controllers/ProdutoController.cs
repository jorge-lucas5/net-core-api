using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;
using MyWebApp.AcessoDados.Entidades;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public async Task<List<Produto>> GetAll()
        {
                var produtos = await _repository.Listar();
                return produtos;
        }

        [HttpGet("{id:int}", Name = "Produto.Get")]
        public async Task<Produto> Get(int id)
        {
            var produto = await _repository.Buscar(id);
            return produto;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto pedido)
        {
            try
            {
                await _repository.Cadastrar(pedido);
                //retonar para outra rota
                return CreatedAtRoute("Produto.Get", new { id = pedido.Id }, pedido);
                //retorna para quem solicitou
                //return Created("Produto.Get", pedido);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }


        }
    }
   
}