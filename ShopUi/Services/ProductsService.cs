using ShopUi.Models;
using ShopUi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopUi.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _productsRepository.GetProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productsRepository.GetProductById(id);
        }
    }
}
