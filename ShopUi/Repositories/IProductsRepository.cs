using ShopUi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopUi.Repositories
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
    }
}
