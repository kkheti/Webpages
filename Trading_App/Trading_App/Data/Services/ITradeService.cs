using Trading_App.Models;

namespace Trading_App.Data.Services
{
    public interface ITradeService
    {
        Task<string> GetTrades();
        Task Sync_Db(List<TradeEntity> selectedSymbols);
        List<TradeEntity> All_Trades();

        List<Watchlist_Entity> Watchlist_Trades();

        Task Update_Watchlist_Db(List<Watchlist_Entity> selectedWatchlist);
    }
}
