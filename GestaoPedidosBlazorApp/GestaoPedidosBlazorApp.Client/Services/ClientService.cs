using GestaoPedidos.DTO;
using GestaoPedidosBlazorApp.Client.Models;
using System.Net.Http.Json;

namespace GestaoPedidosBlazorApp.Client.Services
{
    public class ClientService
    {

        private readonly HttpClient _httpClient;

        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Cliente>>("api/Client");
            return response ?? new List<Cliente>();
        }

        public async Task<List<ClientAddressDTO>> GetClientesSelectAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ClientAddressDTO>>("api/Client/selects");
            return response ?? new List<ClientAddressDTO>();
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Client", cliente);
            response.EnsureSuccessStatusCode();
        }
    }
}
