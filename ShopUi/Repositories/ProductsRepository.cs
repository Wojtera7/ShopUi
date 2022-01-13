using ShopUi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using System.Net.Http;
using System.Net.Http.Json;


namespace ShopUi.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        public async Task<List<Product>> GetProducts()
        {
            // Call Api
            //
            //var products = new List<Product>();

            //products.Add(new Product
            //{
            //    Id = 1,
            //    Title = "Black Bag",
            //    Description = "A black bag - nice!",
            //    Image = $"/assets/images/1.jpg",
            //    Location = "Someplace, NC",
            //    Price = 50m
            //});
            //products.Add(new Product
            //{
            //    Id = 2,
            //    Title = "Blue Shirt",
            //    Description = "A blue t-shirt",
            //    Image = $"/assets/images/2.jpg",
            //    Location = "SomeplaceElse, NC",
            //    Price = 15m
            //});
            //return products;

            //var httpClient = new HttpClient();
            //var products = await httpClient.GetFromJsonAsync<List<Product>>("https://localhost:44328/api/Products");
            //return products;

            return await "https://localhost:44328"
                            .AppendPathSegment("/api/Products")
                                .GetJsonAsync<List<Product>>();
        }
        public async Task<Product> GetProductById(int id)
        {
            return await "https://localhost:44328"
                            .AppendPathSegment($"/api/Products/{id}")
                                .GetJsonAsync<Product>();
        }
    }
}
