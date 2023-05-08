using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {

        Task AddProductAsync(Product product);
        Task DeleteProductAsync(int productId);
        Task EditProductAsync(Product product);
        Task<Product> GetProductAsync(int productId);
        Task<IReadOnlyList<Product>> GetProductsAsync();


    }
}