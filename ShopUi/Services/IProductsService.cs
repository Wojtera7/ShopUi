using ShopUi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopUi.Services
{
    public interface IProductsService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
    }
}
