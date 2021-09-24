﻿using APICatalogo.Models;
using APICatalogo.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APICatalogo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IUnitOfWork _uof;
        public ProdutosController(IUnitOfWork contexto)
        {
            _uof = contexto;
        }

        [HttpGet("menorpreco")]
        public ActionResult<IEnumerable<Produto>> GetProdutosPrecos()
        {
            return _uof.ProdutoRepository.GetProdutosPorPreco().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return _uof.ProdutoRepository.Get().ToList();
        }

        [HttpGet("{id:int:min(1)}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _uof.ProdutoRepository.GetById(p => p.Id == id);
            if(produto == null)
            {
                return NotFound();
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post([FromBody]Produto produto)
        {
            _uof.ProdutoRepository.Add(produto);
            _uof.Commit();

            return new CreatedAtRouteResult("ObterProduto", new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody] Produto produto)
        {
            if(id != produto.Id)
            {
                return BadRequest();
            }

            _uof.ProdutoRepository.Update(produto);
            _uof.Commit();
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<Produto>Delete(int id)
        {
            var produto = _uof.ProdutoRepository.GetById(p => p.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            _uof.ProdutoRepository.Delete(produto);
            _uof.Commit();

            return produto;
        }

    }
}
