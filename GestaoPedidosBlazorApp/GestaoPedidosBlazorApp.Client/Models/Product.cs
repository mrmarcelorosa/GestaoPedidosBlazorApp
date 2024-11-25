namespace GestaoPedidosBlazorApp.Client.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Sku { get; set; }
        public DateTime? DateDelete { get; set; }
    }
}
