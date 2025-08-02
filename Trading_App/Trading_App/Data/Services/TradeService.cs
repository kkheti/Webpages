using Trading_App.Models;
using System.Net.Http.Headers;

namespace Trading_App.Data.Services
{
    public class TradeService : ITradeService
    {
        private readonly Trading_Context _context;

        public TradeService(Trading_Context context)
        { 
            _context = context; 
        }

        //First of all make sure you are getting data till here 
        
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
                // Just execute the Service and come to this point
                // Don't upload to the database , only try to run the service.
                // This should represent what we are getting 
                Console.WriteLine(body);
                return body;
            }
        }
    }
}
