using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using Trading_App.Models;

namespace Trading_App.Data.Services
{
    public class TradeService : ITradeService
    {
        private readonly Trading_Context _context;

        public TradeService(Trading_Context context)
        {
            _context = context;
        }

       

        public async Task<string> GetTrades()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://yahoo-finance15.p.rapidapi.com/api/v1/markets/insider-trades"),
                Headers =
                {
                    { "x-rapidapi-key", "432267d6c9msh11ed843df42acabp1dcfffjsn32272c2c066d" },
                    { "x-rapidapi-host", "yahoo-finance15.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
              
                return body;
            }
        }
        public List<TradeEntity> All_Trades()   
        {
            return (_context.SavedTrades.ToList());
        }

        public List<Watchlist_Entity> Watchlist_Trades()
        {
            return(_context.Watchlist.ToList());
        }

        public async Task Sync_Db(List<TradeEntity> selectedTrades)
        {

            _context.RemoveRange(_context.SavedTrades);
            await _context.AddRangeAsync(selectedTrades);
            await _context.SaveChangesAsync();
        }

        public async Task Update_Watchlist_Db(List<Watchlist_Entity> selectedWatchlist)
        {
            _context.RemoveRange(_context.Watchlist);
            await _context.AddRangeAsync(selectedWatchlist);
            await _context.SaveChangesAsync();
        }
        
    }
}
