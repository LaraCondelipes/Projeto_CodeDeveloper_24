using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;
using Projeto_CodeDeveloper_24.Repository;

namespace Projeto_CodeDeveloper_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IRepository<Receitas> _receitasRepositorio;
        //private readonly IRepository<Ingredientes> _ingredientesRepositorio;

        public ReceitasController(IRepository<Receitas> receitasRepositorio)
        {
            _receitasRepositorio = receitasRepositorio;
            //_ingredientesRepositorio = ingredientesRepositorio;
        }

        // GET: api/Receitas
        [HttpGet]
        public IEnumerable<Receitas> GetReceitas()
        {
            return _receitasRepositorio.All();
        }

        // GET: api/Receitas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receitas>> GetReceitas(int id)
        {
            //var receitas = await _context.Receitas.FindAsync(id);
            var receitas = _receitasRepositorio.Get(id);

            if (receitas == null)
            {
                return NotFound();
            }

            return receitas;
        }

        // PUT: api/Receitas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceitas(int id, Receitas receitas)
        {
            if (id != receitas.Id)
            {
                return BadRequest();
            }
            
            //_context.Entry(receitas).State = EntityState.Modified;

            try
            {
                _receitasRepositorio.Update(receitas);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceitasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Receitas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Receitas>> PostReceitas(Receitas receitas)
        {
            _receitasRepositorio.Add(receitas);

            return CreatedAtAction("GetReceitas", new { id = receitas.Id }, receitas);
        }

        // DELETE: api/Receitas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceitas(int id)
        {
            _receitasRepositorio.Delete(id);

            return NoContent();
        }

        private bool ReceitasExists(int id)
        {
            
            return _receitasRepositorio.All().Any(x => x.Id == id);
        }
    }
}
