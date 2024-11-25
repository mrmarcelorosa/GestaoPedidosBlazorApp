namespace GestaoPedidosBlazorApp.Client.Models
{
    public class OrderHeader
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ClientEmail { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;

        public double TotalPrice {  get; set; }
        public DateTime OrderDate { get; set; }
    }
}
