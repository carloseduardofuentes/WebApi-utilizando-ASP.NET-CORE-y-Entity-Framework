using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        private readonly CargoContext _context;

        public PerfilController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tperfil>>> Get()
        {
            try
            {
             
                var p_codigo_perfil = new SqlParameter("@p_codigo_perfil", DBNull.Value);
                var p_perfil = new SqlParameter("@p_nombre_perfil", DBNull.Value);

                var lista = await _context
                       .Tperfils
                       .FromSqlRaw("exec prc_slcPerfil @p_codigo_perfil, @p_nombre_perfil",
                           p_codigo_perfil, p_perfil)
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
        public async Task<ActionResult<Tperfil>> GetById(decimal id)
        {

            try
            {                
                var p_codigo_perfil = new SqlParameter("@p_codigo_perfil", id);
                var p_perfil = new SqlParameter("@p_nombre_perfil", DBNull.Value);

                var lista = await _context
                       .Tperfils
                       .FromSqlRaw("exec prc_slcPerfil @p_codigo_perfil, @p_nombre_perfil",
                           p_codigo_perfil, p_perfil)
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