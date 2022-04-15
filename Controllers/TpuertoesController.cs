#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TpuertoesController : ControllerBase
    {
        private readonly CargoContext _context;

        public TpuertoesController(CargoContext context)
        {
            _context = context;
        }

        // GET: api/Tpuertoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpuerto>>> GetTpuertos()
        {
            return await _context.Tpuertos.ToListAsync();
        }

        // GET: api/Tpuertoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpuerto>> GetTpuerto(decimal id)
        {
            var tpuerto = await _context.Tpuertos.FindAsync(id);

            if (tpuerto == null)
            {
                return NotFound();
            }

            return tpuerto;
        }

        // PUT: api/Tpuertoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpuerto(decimal id, Tpuerto tpuerto)
        {
            if (id != tpuerto.NCodigoPuerto)
            {
                return BadRequest();
            }

            _context.Entry(tpuerto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpuertoExists(id))
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

        // POST: api/Tpuertoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tpuerto>> PostTpuerto(Tpuerto tpuerto)
        {
            _context.Tpuertos.Add(tpuerto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTpuerto", new { id = tpuerto.NCodigoPuerto }, tpuerto);
        }

        // DELETE: api/Tpuertoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTpuerto(decimal id)
        {
            var tpuerto = await _context.Tpuertos.FindAsync(id);
            if (tpuerto == null)
            {
                return NotFound();
            }

            _context.Tpuertos.Remove(tpuerto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TpuertoExists(decimal id)
        {
            return _context.Tpuertos.Any(e => e.NCodigoPuerto == id);
        }
    }
}
