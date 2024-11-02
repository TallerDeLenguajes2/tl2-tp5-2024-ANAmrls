using TP5.Models;

namespace TP5.Repositorios
{
    public class PresupuestosRepository : IPresupuestosRepository
    {
        public void CreatePresupuesto(Presupuesto presupuesto) { throw new NotImplementedException(); }

        public List<Presupuesto> GetAll() { throw new NotImplementedException(); }


        public void AddProducto(int idPresupuesto, int idProducto, int cantidad) { throw new NotImplementedException(); }

        public void DeletePresupuesto(int idPresupuesto) { throw new NotImplementedException(); }

        public Presupuesto GetPresupuestoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
