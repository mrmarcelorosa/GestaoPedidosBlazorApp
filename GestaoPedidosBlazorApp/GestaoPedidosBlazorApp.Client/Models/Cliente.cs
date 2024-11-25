using System.Net;

namespace GestaoPedidosBlazorApp.Client.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;
        public string Phone { get; set; } = String.Empty;
        public List<Address> Addresses { get; set; }


    }
}
