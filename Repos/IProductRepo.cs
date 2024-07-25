using NSK_Food_City.Database;

namespace NSK_Food_City.Repos
{
    public interface IProductRepo
    {
        Task<Product> addProduct(Product product);
        Task<List<Product>> getAllProducts();

        Task<Product> getProductById(Guid id);

        Task<Product> editProduct(Product product);
    }
}
