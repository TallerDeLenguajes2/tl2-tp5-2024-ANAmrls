using TP5.Models;

namespace TP5.Repositorios
{
    public interface IPresupuestosRepository
    {
        void AddProducto(int idPresupuesto, PresupuestoDetalle detalle);
        void CreatePresupuesto(Presupuesto presupuesto);
        void DeletePresupuestoById(int idPresupuesto);
        List<Presupuesto> GetPresupuestos();
        Presupuesto GetPresupuestoById(int id);
    }
}