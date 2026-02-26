using GameStore.Models;
using GameStore.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);

        Product GetProduct(int id);
        void UpdateProduct(Product product);
        void UpdateAll(Product[] products);
        void DeleteProduct(Product product);

        IEnumerable<Product> GetTopSellingProducts(int count);

        PagedList<Product> GetProducts(QueryOptions options);
    }
}
