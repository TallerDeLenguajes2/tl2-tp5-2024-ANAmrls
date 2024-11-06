using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TP5.Models;
using TP5.Repositorios;

namespace TP5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private readonly IPresupuestosRepository _presupuestosRepository;

        public PresupuestoController(IPresupuestosRepository presupuestosRepository)
        {
            _presupuestosRepository = presupuestosRepository;
        }

        [HttpPost]
        public ActionResult CreatePresupuesto(Presupuesto presupuesto)
        {
            _presupuestosRepository.CreatePresupuesto(presupuesto);
            return Created();
        }

        [HttpPost("{id}/ProductoDetalle")]
        public ActionResult AddProductoDetalleToPresupuesto(int id, PresupuestoDetalle detalle)
        {
            _presupuestosRepository.AddProducto(id, detalle);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Presupuesto>> GetPresupuestos()
        {
            var presupuestos = _presupuestosRepository.GetPresupuestos();
            return Ok(presupuestos);
        }

        [HttpGet("{id}")]
        public ActionResult<Presupuesto> GetPresupuestoById(int id)
        {
            var presupuesto = _presupuestosRepository.GetPresupuestoById(id);
            return Ok(presupuesto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePresupuesto(int id)
        {
            _presupuestosRepository.DeletePresupuestoById(id);
            return NoContent();
        }
    }
}
