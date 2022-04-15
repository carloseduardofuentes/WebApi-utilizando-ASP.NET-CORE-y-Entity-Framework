using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaisControllerTablas : ControllerBase
    {
        private readonly CargoContext _context;

        public PaisControllerTablas(CargoContext context)
        {
            _context = context;   
        }

        [HttpGet(Name = "Tpai")]
        public async Task<ActionResult<List<Tpai>>> Get()
        {
            //using (var context = new CargoContext())
            //{
            //    //return context.Tpais.ToList();

            //    //return context.Tpais.Where(auth => auth.NCodigoPais == 1).ToList();

            //    return Ok(await context.Tpais.ToListAsync());

            //}

            return Ok(await _context.Tpais.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tpai>> GetId(decimal id)
        {

            //var tpai = context.Tpais.Where(auth => auth.NCodigoPais == id).SingleOrDefault();

            var tpai = await _context.Tpais.FindAsync(id);
            if (tpai == null)
            {
                return NotFound();
            }

            return Ok(tpai);
        }


        [HttpPost]
        public async Task<ActionResult<List<Tpai>>> Create(Tpai tpai)
        {
            _context.Tpais.Add(tpai);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tpais.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Tpai>>> Update(Tpai tpai)
        {
            var tpai2 = await _context.Tpais.FindAsync(tpai.NCodigoPais);
            if (tpai2 == null)
            {
                return NotFound();
            }

            tpai2.NCodigoPais = tpai.NCodigoPais;
            tpai2.CPais = tpai.CPais;
            await _context.SaveChangesAsync();

            return Ok(await _context.Tpais.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Tpai>>> Delete(decimal id)
        {
            var tpai = await _context.Tpais.FindAsync(id);
            if (tpai == null)
            {
                return NotFound();
            }

            _context.Tpais.Remove(tpai);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tpais.ToListAsync());
        }
    }
}