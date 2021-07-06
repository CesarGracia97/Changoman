using ArticulosTecnologicos.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ArticulosTecnologicos.Shared.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArticulosTecnologicos.Server.Controllers
    //Controlador API de libros
{
    [Route("api/[controller]")] //ruta de la API
    [ApiController]
    public class InformacionsController : ControllerBase
    {
        private ArticulosContext _context;
        public InformacionsController(ArticulosContext context)
        {
            _context = context; 
            //Objeto apuntador con el que se dirige la informacion por los metodos HTTP
        }

        // GET: api/<BooksController>
        // Metodo GET para la obtencion de datos.
        [HttpGet]
        public object Get()
        {
            return new { Items = _context.Informacions, Count = _context.Informacions.Count() };
        }

        // Metodo POST para el envio de datos a la tabla
        [HttpPost]
        public void Post([FromBody] Informacion informacion)
        {
            _context.Informacions.Add(informacion);
            _context.SaveChanges();
        }

        // Metodo PUT para la obtencion de Datos para la tabla
        [HttpPut]
        public void Put(int id, [FromBody] Informacion informacion)
        {
            Informacion _informacion = _context.Informacions.Where(x => x.Id.Equals(informacion.Id)).FirstOrDefault();
            _informacion.Nombre = informacion.Nombre;
            _informacion.Detalles = informacion.Detalles;
            _informacion.Cantidad = informacion.Cantidad;
            _informacion.Precio = informacion.Precio;
            _informacion.Stock = informacion.Stock;
            _informacion.Existencia = informacion.Existencia;
            _context.SaveChanges();
        }

        // DELETE api/<BooksController>
        // Metodo para eliminacion de Columna, elimina la columna del ID seleccionado
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Informacion _informacion = _context.Informacions.Where(x => x.Id.Equals(id)).FirstOrDefault();
            _context.Informacions.Remove(_informacion);
            _context.SaveChanges();
        }
    }
}
