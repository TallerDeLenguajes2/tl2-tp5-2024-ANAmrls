using Microsoft.AspNetCore.Mvc;
using TP5.Models;
using TP5.Repositorios;

namespace TP5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            var productos = _productoRepository.GetProductos();
            return Ok(productos);
        }

        [HttpPost]
        public ActionResult CreateProducto(Producto producto)
        {
            _productoRepository.CreateProducto(producto);
            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult CambiarNombre(int id, string nuevoNombre)
        {
            var producto = _productoRepository.GetProductoById(id);
            producto.Description = nuevoNombre;
            _productoRepository.UpdateProducto(id, producto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProducto(int id)
        {
            _productoRepository.DeleteProductoById(id);
            return NoContent();
        }
    }
}
