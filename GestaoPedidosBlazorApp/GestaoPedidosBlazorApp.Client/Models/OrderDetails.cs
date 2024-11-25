﻿namespace GestaoPedidosBlazorApp.Client.Models
{
    public class OrderDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
