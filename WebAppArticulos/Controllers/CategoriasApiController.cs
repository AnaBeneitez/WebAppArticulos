using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppArticulos.Models;
using WebAppArticulos.Models.DTO_s;
using WebAppArticulos.Persistencia;

namespace WebAppArticulos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasApiController : ControllerBase
    {
        private readonly ArticuloContext _context;

        public CategoriasApiController(ArticuloContext context)
        {
            _context = context;
        }

        // GET: api/CategoriasApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> GetCategorias()
        {
            try
            {
                var categorias = await _context.Categorias.Include(c => c.Productos).ToListAsync();
                var categoriasDTO = new List<CategoriaDTO>();
                categoriasDTO = categorias.Select(c => new CategoriaDTO(c)).ToList();

                return Ok(categoriasDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // GET: api/CategoriasApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaDTO>> GetCategoria(long id)
        {
            try
            {
                var categoria = await _context.Categorias.Include(c => c.Productos)
                                                         .FirstOrDefaultAsync(m => m.Id == id);

                if (categoria == null)
                {
                    return NotFound();
                }

                var categoriaDTO = new CategoriaDTO(categoria);

                return Ok(categoriaDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // PUT: api/CategoriasApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria(long id, Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return BadRequest();
            }

            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
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

        // POST: api/CategoriasApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = categoria.Id }, categoria);
        }

        // DELETE: api/CategoriasApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoria(long id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoriaExists(long id)
        {
            return _context.Categorias.Any(e => e.Id == id);
        }
    }
}
