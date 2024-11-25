namespace GestaoPedidosBlazorApp.Client.Models
{
    public class OrderCreateRequest
    {
        public int ClientId { get; set; }
        public int BillingAddressId { get; set; }
        public int DeliveryAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
