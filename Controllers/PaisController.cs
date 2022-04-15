using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaisController : ControllerBase
    {
        private readonly CargoContext _context;

        public PaisController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Get")]
        public async Task<ActionResult<List<Tpai>>> Get()
        {
            try
            {
                //using (var context = new CargoContext())
                //{
                //    var p_codigo_pais = new SqlParameter("@p_codigo_pais", "-1");
                //    var p_pais = new SqlParameter("@p_pais", "%%");

                //    var users = context
                //           .Tpais
                //           .FromSqlRaw("exec prc_slcPais @p_codigo_pais, @p_pais",
                //               p_codigo_pais, p_pais)
                //           .ToList();
                //    return users;
                //}

                var p_codigo_pais = new SqlParameter("@p_codigo_pais", DBNull.Value);
                var p_pais = new SqlParameter("@p_pais", DBNull.Value);

                var paises = await _context
                       .Tpais
                       .FromSqlRaw("exec prc_slcPais @p_codigo_pais, @p_pais",
                           p_codigo_pais, p_pais)
                       .ToListAsync();

                if (paises.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(paises);
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tpai>> GetById(decimal id)
        {

            try
            {
                var p_codigo_pais = new SqlParameter("@p_codigo_pais", id);
                var p_pais = new SqlParameter("@p_pais", DBNull.Value);

                var paises = await _context
                       .Tpais
                       .FromSqlRaw("exec prc_slcPais @p_codigo_pais, @p_pais",
                           p_codigo_pais, p_pais)
                       .ToListAsync();

                if (paises.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(paises.FirstOrDefault());
            }
            catch (Exception e)
            {
                return BadRequest("Error");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(Tpai model)
        {
            try
            {
                var p_pais = new SqlParameter("@p_pais", model.CPais);
                
                await _context.Database.ExecuteSqlRawAsync("EXEC prc_insPais @p_pais",
                                                            p_pais);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
                throw;
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Tpai model)
        {
            try
            {
                //Agregar validacion si existe registro en tabla
                var p_codigo_pais = new SqlParameter("@p_codigo_pais", model.NCodigoPais);
                var p_pais = new SqlParameter("@p_pais", DBNull.Value);
                
                var paises = await _context
                       .Tpais
                       .FromSqlRaw("exec prc_slcPais @p_codigo_pais, @p_pais",
                           p_codigo_pais, p_pais)
                       .ToListAsync();

                if (paises.Count() == 0)
                {
                    return NotFound();
                }

                p_pais = new SqlParameter("@p_pais", model.CPais);
                await _context.Database.ExecuteSqlRawAsync("EXEC prc_updPais @p_codigo_pais, @p_pais",
                                                            p_codigo_pais, p_pais);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
                throw;
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var p_codigo_pais = new SqlParameter("@p_codigo_pais", id);
                var p_pais = new SqlParameter("@p_pais", DBNull.Value);

                //Agregar validacion si existe registro en tabla
                var paises = await _context
                      .Tpais
                      .FromSqlRaw("exec prc_slcPais @p_codigo_pais, @p_pais",
                          p_codigo_pais, p_pais)
                      .ToListAsync();

                if (paises.Count() == 0)
                {
                    return NotFound();
                }

                await _context.Database.ExecuteSqlRawAsync("EXEC prc_delPais @p_codigo_pais",
                                                            p_codigo_pais);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
                throw;
            }
        }
    }
}