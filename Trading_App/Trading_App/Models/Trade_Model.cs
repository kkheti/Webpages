namespace Trading_App.Models
{
    public class Trade_Model
    {
        public int Id { get; set; }
        public double aveg_pricePerShare {  get; set; }
        public DateTime date {  get; set; }
        public string linkToFilingDetails {  get; set; }
        public long num_shares_own {  get; set; }
        public string reportingOwnerAddress {  get; set; }
        public long sum_transactionShares {  get; set; }
        public string symbol {  get; set; }
        public double tot_value {  get; set; }
        public char transactionCode {  get; set; }
    }
}
