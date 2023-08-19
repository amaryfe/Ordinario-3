using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Examen.Models;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var listComments = await _context.Servicios.ToListAsync();
            if (listComments == null || listComments.Count == 0)
            {
                return NoContent();
            }
            return Ok(listComments);
        }

        [HttpGet("Show")]
        public async Task<IActionResult> Show(int id)
        {
            var comment = await _context.Servicios.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        [HttpPost("Store")]
        public async Task<HttpStatusCode> Store([FromBody] Servicio servicios)
        {
            if (servicios == null)
            {
                //hola
                return HttpStatusCode.BadRequest;
            }
            _context.Add(servicios);
            await _context.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpDelete("Destroy")]
        public async Task<IActionResult> Destroy(int id)
        {
            var comment = await _context.Servicios.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            _context.Servicios.Remove(comment);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Servicio servicios){
            if(servicios == null ){
                return BadRequest();
            }

            var entity = await _context.Servicios.FindAsync(servicios.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Nombre = servicios.Nombre;
            entity.Descripcion = servicios.Descripcion;
            entity.Costo = servicios.Costo;
            entity.RequisitosPrevios = servicios.RequisitosPrevios;
            
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}