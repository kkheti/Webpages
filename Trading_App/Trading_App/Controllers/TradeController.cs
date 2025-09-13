using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Trading_App.Data;
using Trading_App.Data.Services;
using Trading_App.Models;

namespace Trading_App.Controllers
{
    public class TradeController : Controller
    {
        private readonly ITradeService _tradeService;

        //ASP.NET Core controller actions don’t share state between requests.
        private OpenData All_trades {  get; set; }
        
        public TradeController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        public async Task<IActionResult> Index()
        {
            var tradesJson = await _tradeService.GetTrades();
            All_trades = JsonConvert.DeserializeObject<OpenData>(tradesJson);
            All_trades.watchlistTrades =  _tradeService.Watchlist_Trades();
            await _tradeService.Sync_Db(All_trades.body);
            //var Watchlist = _tradeService.Sync_Db();


            return View(All_trades);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSelected(List<string> selectedSymbols)
        {
            //var tradesJson = await _tradeService.GetTrades();
            //All_trades = JsonConvert.DeserializeObject<OpenData>(tradesJson);
            List<TradeEntity> LatestTrades = _tradeService.All_Trades();
            List<Watchlist_Entity> selectedTrades = LatestTrades
                                               .Where(t => selectedSymbols.Contains(t.Symbol))
                                               .Select(t => new Watchlist_Entity
                                               {
                                                   Symbol = t.Symbol,
                                                   SymbolName = t.SymbolName,
                                                   reportedPrice = t.reportedPrice    
                                               }).ToList();
            
            await _tradeService.Update_Watchlist_Db(selectedTrades);
            return RedirectToAction("Index");
        }

    }

    public class OpenData
    {
        public List<TradeEntity> body {  get; set; }
        public List<Watchlist_Entity> watchlistTrades { get; set; }

    }
    public class TradeViewModel
    {
        public List<TradeEntity> Atrades { get; set; }
        public List<Watchlist_Entity> watchlistTrades { get; set; }
    }

   

}
