using GestaoPedidosBlazorApp.Client.Models;
using System.Net.Http.Json;

namespace GestaoPedidosBlazorApp.Client.Services
{
    public class ProductService
    {

        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            return response ?? new List<Product>();
        }

        public async Task<List<ProductDTO>> GetProductsSelectAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductDTO>>("api/Product/selects");
            return response ?? new List<ProductDTO>();
        }

        public async Task AddProductAsync(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Product", product);
            response.EnsureSuccessStatusCode();
        }
    }
}
