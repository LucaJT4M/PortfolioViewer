namespace PortfolioViewer.DLL.Classes
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int PortfolioOwnerId { get; set; }
        public List<int> StockIds { get; set; } = [];
        public DateTime PortfolioCreated { get; set; }
    }
}