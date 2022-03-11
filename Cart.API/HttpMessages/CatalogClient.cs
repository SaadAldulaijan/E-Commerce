using Cart.API.Models;
using Newtonsoft.Json;

namespace Cart.API.HttpMessages
{
    public class CatalogClient : ICatalogClient
    {
        private readonly HttpClient _httpClient;

        public CatalogClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var response = await _httpClient.GetAsync($"/api/products/{id}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var product = JsonConvert.DeserializeObject<Product>(jsonResponse);
                    return product;
                }
                return null;
            }
        }


        public async Task<List<Product>> GetProducts()
        {
            using (var response = await _httpClient.GetAsync($"/api/products"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
                    return products;
                }
                return null;
            }
        }
    }
}
