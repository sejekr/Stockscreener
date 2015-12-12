using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
