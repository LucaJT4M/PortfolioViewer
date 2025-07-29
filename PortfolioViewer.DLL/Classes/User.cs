namespace PortfolioViewer.DLL.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public List<int> PortfolioIds { get; set; } = new List<int>();
    }
}