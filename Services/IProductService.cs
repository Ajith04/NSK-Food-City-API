using NSK_Food_City.Database;
using NSK_Food_City.DTO.Request;
using NSK_Food_City.DTO.Response;

namespace NSK_Food_City.Services
{
    public interface IProductService
    {
        Task<ProductResponseDTO> addProduct(ProductRequestDTO productrequestdto);

        Task<List<Product>> getAllProducts();
        Task<Product> getProductById(Guid id);

        Task<Product> editProduct(Product product);
    }
}
