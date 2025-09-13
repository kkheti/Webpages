namespace Trading_App.Models
{
    public class Watchlist_Entity
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string SymbolName { get; set; }
        public double reportedPrice { get; set; }

    }
}
