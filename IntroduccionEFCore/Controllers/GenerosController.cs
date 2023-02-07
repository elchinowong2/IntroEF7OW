using IntroduccionEFCore.DTOs;
using IntroduccionEFCore.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly aplicationDbContext context;
        public GenerosController(aplicationDbContext context)
        {
            this.context = context; 
        }

        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacionDTO generoDTO) {

            var Genero = new Genero
            {
                Nombre = generoDTO.Nombre
            };


            context.Add(Genero);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
