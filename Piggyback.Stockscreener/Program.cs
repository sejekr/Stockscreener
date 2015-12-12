using Microsoft.Practices.Unity;
using Piggyback.Stockscreener.Service;
using System;

namespace Piggyback.Stockscreener
{
  public class Program
  {
    public static void Main(string[] args)
    {
      using (IUnityContainer container = new UnityContainer())
      {
        container.RegisterType<IStockService, StockService>();

        var stockService = container.Resolve<IStockService>();
        Console.WriteLine("Date: " + stockService.GetCurrentDate());
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
      }
    }
  }
}
