using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;

namespace Projeto_CodeDeveloper_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaIngredientesController : ControllerBase
    {
        private readonly ProjetoDbContext _context;

        public ReceitaIngredientesController(ProjetoDbContext context)
        {
            _context = context;
        }

        // GET: api/ReceitaIngredientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReceitaIngredientes>>> GetReceitaIngredientes()
        {
            return await _context.ReceitaIngredientes.ToListAsync();
        }

        // GET: api/ReceitaIngredientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReceitaIngredientes>> GetReceitaIngredientes(int id)
        {
            var receitaIngredientes = await _context.ReceitaIngredientes.FindAsync(id);

            if (receitaIngredientes == null)
            {
                return NotFound();
            }

            return receitaIngredientes;
        }

        // PUT: api/ReceitaIngredientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceitaIngredientes(int receitaId,int ingredienteId, ReceitaIngredientes receitaIngredientes)
        {
            if (receitaId != receitaIngredientes.ReceitasId || ingredienteId != receitaIngredientes.IngredientesId)
            {
                return BadRequest();
            }

            _context.Entry(receitaIngredientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceitaIngredientesExists(receitaId,ingredienteId))
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

        // POST: api/ReceitaIngredientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReceitaIngredientes>> PostReceitaIngredientes(ReceitaIngredientes receitaIngredientes)
        {
            _context.ReceitaIngredientes.Add(receitaIngredientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReceitaIngredientes", new { id = receitaIngredientes.ReceitasId }, receitaIngredientes);
        }

        // DELETE: api/ReceitaIngredientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceitaIngredientes(int id)
        {
            var receitaIngredientes = await _context.ReceitaIngredientes.FindAsync(id);
            if (receitaIngredientes == null)
            {
                return NotFound();
            }

            _context.ReceitaIngredientes.Remove(receitaIngredientes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReceitaIngredientesExists(int receitaId, int ingredienteId)
        {
            return _context.ReceitaIngredientes.Any(e => e.ReceitasId == receitaId && e.IngredientesId == ingredienteId);
        }
    }
}
