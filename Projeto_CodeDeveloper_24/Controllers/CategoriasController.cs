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
    public class CategoriasController : ControllerBase
    {
        private readonly IRepository<Categorias> _categoriasRepositorio;


        public CategoriasController(IRepository<Categorias> categoriasRepositorio)
        {
            _categoriasRepositorio = categoriasRepositorio;
        }

        // GET: api/Categorias
        [HttpGet]
        public IEnumerable<Categorias> GetCategorias()
        {
            return _categoriasRepositorio.All();
        }

        // GET: api/Categorias/5
        [HttpGet("{id}")]
        public  Categorias GetCategorias(int id)
        {

            var categorias = _categoriasRepositorio.Get(id);

          
            return categorias;
        }

        // PUT: api/Categorias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public void PutCategorias(int id, Categorias categorias)
        {
            if (id != categorias.Id)
            {
                return;
            }
                       
            try
            {
               
                _categoriasRepositorio.Update(categorias);

            }
            catch (DbUpdateConcurrencyException)
            {
              
                    throw;
                
            }

            return;
        }

        // POST: api/Categorias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categorias>> PostCategorias(Categorias categorias)
        {

            _categoriasRepositorio.Add(categorias);
            
            return CreatedAtAction("GetCategorias", new { id = categorias.Id }, categorias);
        }

        // DELETE: api/Categorias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorias(int id)
        {
           _categoriasRepositorio.Delete(id);

            return NoContent();
        }

        private bool CategoriasExists(int id)
        {
            return _categoriasRepositorio.All().Any(e => e.Id == id);
        }
    }
}
