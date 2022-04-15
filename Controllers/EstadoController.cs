using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoController : ControllerBase
    {
        private readonly CargoContext _context;

        public EstadoController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Testado>>> Get()
        {
            try
            {
             
                var p_codigo_estado = new SqlParameter("@p_codigo_estado", DBNull.Value);
                var p_estado = new SqlParameter("@p_estado", DBNull.Value);

                var lista = await _context
                       .Testados
                       .FromSqlRaw("exec prc_slcEstado @p_codigo_estado, @p_estado",
                           p_codigo_estado, p_estado)
                       .ToListAsync();

                if (lista.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Testado>> GetById(decimal id)
        {

            try
            {
                var p_codigo_estado = new SqlParameter("@p_codigo_estado", id);
                var p_estado = new SqlParameter("@p_estado", DBNull.Value);


                var lista = await _context
                        .Testados
                        .FromSqlRaw("exec prc_slcEstado @p_codigo_estado, @p_estado",
                            p_codigo_estado, p_estado)
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