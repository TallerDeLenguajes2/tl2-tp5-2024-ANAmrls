using TP5.Models;

namespace TP5.Repositorios
{
    public interface IProductoRepository
    {
        void CreateProducto(Producto producto);
        void DeleteProductoById(int id);
        Producto GetProductoById(int id);
        List<Producto> GetProductos();
        void UpdateProducto(int idProducto, Producto producto);
    }
}