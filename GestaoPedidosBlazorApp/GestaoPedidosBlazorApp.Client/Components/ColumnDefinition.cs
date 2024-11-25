namespace GestaoPedidosBlazorApp.Client.Components
{
    public class ColumnDefinition<T>
    {
        public string Header { get; set; }
        public Func<T, object> PropertySelector { get; set; }
    }
}
