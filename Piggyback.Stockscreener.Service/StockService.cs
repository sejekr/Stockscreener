using System;

namespace Piggyback.Stockscreener.Service
{
  public class StockService : IStockService
  {
    public DateTime GetCurrentDate()
    {
      return DateTime.Now;
    }
  }
}
