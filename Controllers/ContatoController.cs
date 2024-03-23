using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        public readonly AgendaContext _context;

        public ContatoController(AgendaContext context) 
        {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("ObterPorNomeEId")]
        public IActionResult ObterPorNomeEId(string nome, int id)
        {
            var contato = _context.Contatos.Where(x => x.Nome.Equals(nome) && x.Id.Equals(id));
            if (!contato.Any() || contato == null)
                return NotFound();
            
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();
            
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Status = contato.Status;
            contatoBanco.Telefone = contato.Telefone;

            _context.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();
            
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return NoContent();
        }
    }
}