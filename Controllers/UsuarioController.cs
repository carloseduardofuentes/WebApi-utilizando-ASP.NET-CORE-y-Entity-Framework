using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;
using WebApi_CargoWeb.Models.ViewModels;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly CargoContext _context;

        public UsuarioController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TusuarioVM>>> Get()
        {
            try
            {
                var p_codigo_usuario = new SqlParameter("@p_codigo_usuario", DBNull.Value);
                var p_nombre_persona = new SqlParameter("@p_nombre_persona", DBNull.Value);
                var p_nombre_usuario = new SqlParameter("@p_nombre_usuario", DBNull.Value);
                var p_password = new SqlParameter("@p_password", DBNull.Value);

                var lista = await _context
                       .TusuariosVM
                       .FromSqlRaw("exec prc_slcUsuario @p_codigo_usuario, @p_nombre_persona, @p_nombre_usuario, @p_password",
                           p_codigo_usuario, p_nombre_persona, p_nombre_usuario, p_password)
                       .ToListAsync();

                if (lista.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TusuarioVM>> GetById(decimal? id)
        {

            try
            {   
                var p_codigo_usuario = new SqlParameter("@p_codigo_usuario", id);
                var p_nombre_persona = new SqlParameter("@p_nombre_persona", DBNull.Value);
                var p_nombre_usuario = new SqlParameter("@p_nombre_usuario", DBNull.Value);
                var p_password = new SqlParameter("@p_password", DBNull.Value);

                var lista = await _context
                       .TusuariosVM
                       .FromSqlRaw("exec prc_slcUsuario @p_codigo_usuario, @p_nombre_persona, @p_nombre_usuario, @p_password",
                           p_codigo_usuario, p_nombre_persona, p_nombre_usuario, p_password)
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

        [HttpPost(Name = "Login")]
        public async Task<ActionResult> Login(Login model)
        {
            try
            {
                var p_nombre_usuario = new SqlParameter("@p_nombre_usuario", model.usuario);
                var p_password = new SqlParameter("@p_password", model.password);

                var lista = await _context
                       .TusuariosVM
                       .FromSqlRaw("EXEC prc_Login @p_nombre_usuario, @p_password", p_nombre_usuario, p_password)
                       .ToListAsync();

                if (lista.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(lista.FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
                throw;
            }
        }

    }
}