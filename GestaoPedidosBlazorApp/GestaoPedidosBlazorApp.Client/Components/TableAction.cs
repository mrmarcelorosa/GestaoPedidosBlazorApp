namespace GestaoPedidosBlazorApp.Client.Components
{
    public class TableAction
    {
        public string Label { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public Action<object> Action { get; set; }
    }
}
