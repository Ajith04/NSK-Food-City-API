using NSK_Food_City.Database;
using NSK_Food_City.DTO.Request;
using NSK_Food_City.DTO.Response;
using NSK_Food_City.Repos;

namespace NSK_Food_City.Services
{
    public class ProductService : IProductService
    {
        private IProductRepo _iproductrepo;

        public ProductService(IProductRepo iproductrepo)
        {
            _iproductrepo = iproductrepo;
        }

        public async Task<ProductResponseDTO> addProduct(ProductRequestDTO productrequestdto)
        {
            var product = new Product();
            product.ProductName = productrequestdto.ProductName;
            product.ProductQuantity = productrequestdto.ProductQuantity;
            product.Price = productrequestdto.Price;

            var data = await _iproductrepo.addProduct(product);
            
            var productresponse = new ProductResponseDTO();
            productresponse.ProductId = data.ProductId;
            productresponse.ProductName = data.ProductName;
            productresponse.ProductQuantity = data.ProductQuantity;
            productresponse.Price = data.Price;

            return productresponse;
        }

        public async Task<List<Product>> getAllProducts()
        {
            var data = await _iproductrepo.getAllProducts();
            return data;
        }

        public async Task<Product> getProductById(Guid id)
        {
            var data = await _iproductrepo.getProductById(id);
            return data;
        }

        public async Task<Product> editProduct(Product product)
        {
            var data = await _iproductrepo.editProduct(product);
            return data;
        }
    }
}
