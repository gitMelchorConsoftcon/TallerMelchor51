using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TallerMelchor.Api.Data;
using TallerMelchor.Api.Models;

namespace TallerMelchor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly Contexto _db;

        public EntradasController(Contexto context)
        {
            _db = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _db.Entrada.ToList();

            return Ok(lista);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _db.Entrada.Find(id);

            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(Entrada obj)
        {
            //var nuevo = new Entrada(obj);
            _db.Entrada.Add(obj);
            _db.SaveChanges();
            return Ok(obj);
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Modificar(int id, Entrada obj)
        {
            var modificar = _db.Entrada.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.IdProveedor = obj.IdProveedor;

            _db.Entrada.Update(modificar);
            _db.SaveChanges();

            return Ok(modificar);
        }
        [HttpPut]
        [Route("{id}/cambiarEstatus")]
        public IActionResult CambiarEstatus(int id)
        {
            var modificar = _db.Entrada.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Activo = !modificar.Activo;

            _db.Entry(modificar).State = EntityState.Modified;
            //            _db.Entrada.Add(modificar);
            _db.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _db.Entrada.Find(id);

            if (borrar == null)
                return NoContent();

            _db.Entrada.Remove(borrar);
            _db.SaveChanges();
            return Ok(borrar);
        }
    }
}
