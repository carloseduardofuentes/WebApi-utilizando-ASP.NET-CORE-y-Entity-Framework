using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModoController : ControllerBase
    {
        private readonly CargoContext _context;

        public ModoController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tmodo>>> Get()
        {
            try
            {
                var p_codigo_modo = new SqlParameter("@p_codigo_modo", DBNull.Value);

                var lista = await _context
                       .Tmodos
                       .FromSqlRaw("exec prc_slcModo @p_codigo_modo",
                           p_codigo_modo)
                       .ToListAsync();

                if (lista.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(lista);
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tmodo>> GetById(decimal id)
        {

            try
            {
                var p_codigo_modo = new SqlParameter("@p_codigo_modo", id);

                var lista = await _context
                       .Tmodos
                       .FromSqlRaw("exec prc_slcModo @p_codigo_modo",
                           p_codigo_modo)
                       .ToListAsync();

                if (lista.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(lista.FirstOrDefault());
            }
            catch (Exception e)
            {
                return BadRequest("Error");
            }
        }
    }
}