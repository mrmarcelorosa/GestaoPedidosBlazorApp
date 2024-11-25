namespace GestaoPedidosBlazorApp.Client.Models
{
    public class Address
    {
        public int Id { get; set; }

        public AddressType AddressType { get; set; }

        public string Logradouro { get; set; } = string.Empty;

        public string NumberAddres { get; set; } = string.Empty;

        public string Complement { get; set; } = string.Empty;

        public string District { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string CEP { get; set; } = string.Empty;

        public Cliente? Client { get; set; }

        public int ClientId { get; set; }
    }
}
