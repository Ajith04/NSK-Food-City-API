using Microsoft.EntityFrameworkCore;
using NSK_Food_City.Database;

namespace NSK_Food_City.Repos
{
    public class ProductRepo : IProductRepo
    {
        private NSKDbContext _nskdbcontext;

        public ProductRepo(NSKDbContext nskdbcontext)
        {
            _nskdbcontext = nskdbcontext;
        }

        public async Task<Product> addProduct(Product product)
        {
            await _nskdbcontext.Products.AddAsync(product);
            await _nskdbcontext.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> getAllProducts()
        {
            return await _nskdbcontext.Products.ToListAsync();
            
        }

        public async Task<Product> getProductById(Guid id)
        {
            return await _nskdbcontext.Products.SingleAsync(r => r.ProductId == id);
        }

        public async Task<Product> editProduct(Product product)
        {
            _nskdbcontext.Products.UpdateRange(product);
            await _nskdbcontext.SaveChangesAsync();
            return product;
        }
    }
}
