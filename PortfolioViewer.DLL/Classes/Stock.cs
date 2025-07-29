namespace PortfolioViewer.DLL.Classes
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal CurrentPrice { get; set; }
        public decimal EnteredPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}