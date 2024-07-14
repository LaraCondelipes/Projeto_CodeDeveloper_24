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
    public class IngredientesController : ControllerBase
    {
        private readonly IRepository<Ingredientes> _ingredientesRepositorio;

        public IngredientesController(IRepository<Ingredientes> ingredientesRepositorio)
        {
            _ingredientesRepositorio = ingredientesRepositorio;
        }

        // GET: api/Ingredientes
        [HttpGet]
        public IEnumerable<Ingredientes> GetIngredientes()
        {
            return _ingredientesRepositorio.All();
        }

        // GET: api/Ingredientes/5
        [HttpGet("{id}")]
        public Ingredientes GetIngredientes(int id)
        {
            var ingredientes =  _ingredientesRepositorio.Get(id);

                       return ingredientes;
        }

        // PUT: api/Ingredientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public void PutIngredientes(int id, Ingredientes ingredientes)
        {
            if (id != ingredientes.Id)
            {
                return;
            }

            
            
            try
            {
                _ingredientesRepositorio.Update(ingredientes);
            }
            catch (DbUpdateConcurrencyException)
            {
              
                    throw;
                
            }

            return;
        }

        // POST: api/Ingredientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ingredientes>> PostIngredientes(Ingredientes ingredientes)
        {
            
            _ingredientesRepositorio.Add(ingredientes);

            return CreatedAtAction("GetIngredientes", new { id = ingredientes.Id }, ingredientes);
        }

        // DELETE: api/Ingredientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredientes(int id)
        {

          _ingredientesRepositorio.Delete(id);


        

            return NoContent();
        }

       
    }
}
