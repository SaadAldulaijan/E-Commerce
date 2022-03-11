using Cart.API.Models;

namespace Cart.API.HttpMessages
{
    public interface ICatalogClient
    {
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProducts();
    }
}
