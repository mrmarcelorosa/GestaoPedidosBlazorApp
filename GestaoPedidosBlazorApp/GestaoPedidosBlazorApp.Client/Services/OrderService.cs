using GestaoPedidosBlazorApp.Client.Models;
using System.Net.Http.Json;

namespace GestaoPedidosBlazorApp.Client.Services
{
    public class OrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<OrderHeader>> GetOrderHeaderAsync(string orderId, string clientName, DateTime ? startDate, DateTime ? endDate)
        {
            var url = "api/orders/headers?";

            if (!string.IsNullOrEmpty(orderId))
            {
                url += $"orderId={orderId}&";
            }

            if (!string.IsNullOrEmpty(clientName))
            {
                url += $"clientName={clientName}&";
            }

            if (startDate.HasValue)
            {
                url += $"startDate={startDate.Value.ToUniversalTime():yyyy-MM-dd}&";
            }

            if (endDate.HasValue)
            {
                url += $"endDate={endDate.Value.ToUniversalTime():yyyy-MM-dd}&";
            }

            url = url.TrimEnd('&');

            var response = await _httpClient.GetFromJsonAsync<List<OrderHeader>>(url);
            return response ?? new List<OrderHeader>();
        }

        public async Task<byte[]> ExportOrderSummaryToExcelAsync(int orderId)
        {
            var response = await _httpClient.GetAsync($"api/orders/{orderId}/export");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }

            var errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception($"Failed to export order summary. Error: {errorMessage}");
        }

        public async Task<bool> PostOrderAsync(OrderCreateRequest order)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/orders", order);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Failed to save order. Error: {errorMessage}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public async Task<List<OrderDetails>> GetOrderDetailsAsync(int orderId)
        {
            var response = await _httpClient.GetFromJsonAsync<List<OrderDetails>>($"api/orders/{orderId}/details");
            return response ?? new List<OrderDetails>();
        }
    }
}
