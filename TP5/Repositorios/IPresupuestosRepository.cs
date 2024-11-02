using TP5.Models;

namespace TP5.Repositorios
{
    public interface IPresupuestosRepository
    {
        void AddProducto(int idPresupuesto, int idProducto, int cantidad);
        void CreatePresupuesto(Presupuesto presupuesto);
        void DeletePresupuesto(int idPresupuesto);
        List<Presupuesto> GetAll();
        Presupuesto GetPresupuestoById(int id);
    }
}