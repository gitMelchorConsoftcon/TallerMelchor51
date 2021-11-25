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
    public class ServiciosController : ControllerBase
    {
        private readonly Contexto _db;

        public ServiciosController(Contexto context)
        {
            _db = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _db.Servicio.ToList();

            return Ok(lista);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _db.Servicio.Find(id);

            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(ServicioDTO obj)
        {
            var nuevo = new Servicio(obj);
            _db.Servicio.Add(nuevo);
            _db.SaveChanges();
            return Ok(nuevo);
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Modificar(int id, ServicioDTO obj)
        {
            var modificar = _db.Servicio.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Nombre = obj.Nombre;

            _db.Servicio.Update(modificar);
            _db.SaveChanges();

            return Ok(modificar);
        }
        [HttpPut]
        [Route("{id}/cambiarEstatus")]
        public IActionResult CambiarEstatus(int id)
        {
            var modificar = _db.Servicio.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Activo = !modificar.Activo;

            _db.Entry(modificar).State = EntityState.Modified;
            _db.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _db.Servicio.Find(id);

            if (borrar == null)
                return NoContent();

            _db.Servicio.Remove(borrar);
            _db.SaveChanges();
            return Ok(borrar);
        }
    }
}

