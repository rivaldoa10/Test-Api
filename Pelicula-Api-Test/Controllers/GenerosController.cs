using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pelicula_Api_Test.DTO;
using Pelicula_Api_Test.Entidad;

namespace Pelicula_Api_Test.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Genero>>> post([FromBody] Genero genero)
        {
            context.Add(genero);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<Genero>>> Get()
        {
            var resultado = await context.Generos.ToListAsync();
            return resultado;
        }

    }
}
