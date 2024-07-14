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
    public class ReceitaIngredientesController : ControllerBase
    {
        private readonly IRepository<ReceitaIngredientes> _receitaIngredientesRepository;

        public ReceitaIngredientesController(IRepository<ReceitaIngredientes> receitaIngredientesRepository) { 


            _receitaIngredientesRepository = receitaIngredientesRepository;
        }

        // GET: api/ReceitaIngredientes
        [HttpGet]
        public IEnumerable<ReceitaIngredientes> GetReceitaIngredientes()
        {
          
            return _receitaIngredientesRepository.All();   
        }

        // GET: api/ReceitaIngredientes/5
        [HttpGet("{id}")]
        public ReceitaIngredientes GetReceitaIngredientes(int id)
        {
            
            var receitaIngredientes = _receitaIngredientesRepository.Get(id);

            
            return receitaIngredientes;
        }

        // PUT: api/ReceitaIngredientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public void PutReceitaIngredientes(int receitaId,int ingredienteId, ReceitaIngredientes receitaIngredientes)
        {
            if (receitaId != receitaIngredientes.ReceitasId || ingredienteId != receitaIngredientes.IngredientesId)
            {
                return;
            }
                                    
            try
            {
                _receitaIngredientesRepository.Update(receitaIngredientes);

            }
            catch (DbUpdateConcurrencyException)
            {
              
                    throw;
                
            }

            return;
        }

        // POST: api/ReceitaIngredientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReceitaIngredientes>> PostReceitaIngredientes(ReceitaIngredientes receitaIngredientes)
        {
            _receitaIngredientesRepository.Add(receitaIngredientes);
            
            return CreatedAtAction("GetReceitaIngredientes", new { id = receitaIngredientes.ReceitasId }, receitaIngredientes);
        }

        // DELETE: api/ReceitaIngredientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceitaIngredientes(int id)
        {
            _receitaIngredientesRepository.Delete(id);

            return NoContent();
        }

        private bool ReceitaIngredientesExists(int receitaId, int ingredienteId)
        {
            return _receitaIngredientesRepository.All().Any(e => e.ReceitasId == receitaId && e.IngredientesId == ingredienteId);
        }
    }
}
