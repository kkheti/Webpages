namespace Trading_App.Models
{
    public class TradeEntity
    {
        public int Id { get; set; }
        public string Symbol {  get; set; }
        public string SymbolName {  get; set; }
        public double reportedPrice { get; set; }
        
    }
}
