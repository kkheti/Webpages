using Trading_App.Models;

namespace Trading_App.Data.Services
{
    public interface ITradeService
    {
        Task<string> GetTrades();
    }
}
