using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TallerMelchor.Api.Data;
using TallerMelchor.Api.DTOS;
using TallerMelchor.Api.Models;

namespace TallerMelchor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly Contexto _db;

        public MarcasController(Contexto context)
        {
            _db = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _db.Marca.ToList();

            return Ok(lista);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _db.Marca.Find(id);

            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(MarcaDTO obj)
        {
            var nuevo = new Marca(obj);
            _db.Marca.Add (nuevo);
            _db.SaveChanges();
            return Ok(nuevo);
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Modificar(int id, MarcaDTO obj)
        {
            var modificar = _db.Marca.Find(id);

            if (modificar == null)
                return NoContent() ;

            modificar.Nombre = obj.Nombre;

            _db.Marca.Update(modificar);
            _db.SaveChanges();

            return Ok(modificar);
        }
        [HttpPut]
        [Route("{id}/cambiarEstatus")]
        public IActionResult CambiarEstatus(int id)
        {
            var modificar = _db.Marca.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Activo = !modificar.Activo;

            _db.Entry(modificar).State = EntityState.Modified;
//            _db.Marca.Add(modificar);
            _db.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _db.Marca.Find(id);

            if (borrar == null)
                return NoContent();

            _db.Marca.Remove(borrar);
            _db.SaveChanges();
            return Ok(borrar);
        }
        }

    
}
