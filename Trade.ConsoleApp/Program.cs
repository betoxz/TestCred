using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Trade.Domain.TradeContext.Entities;

namespace Trade.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string referenceDate = Console.ReadLine();

            string numberTrades = Console.ReadLine();

            Portfolio portifolio = new Portfolio();

            portifolio.ReferenceDate = DateTime.ParseExact(referenceDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            portifolio.trades = new List<Domain.TradeContext.Entities.Trade>();

            var listTrades = new string[int.Parse(numberTrades)];

            for (int i = 0; i < int.Parse(numberTrades); i++)
                listTrades[i] = Console.ReadLine();

            foreach (string s in listTrades)
            {
                portifolio.trades.Add(MapInput(s));
                Console.WriteLine(s);
            }

            Console.WriteLine("\n");

            foreach (var outPrint in portifolio.getCategorias().ToList())
                Console.WriteLine(outPrint.ToString());


            Console.ReadKey();
        }

        private static Domain.TradeContext.Entities.Trade MapInput(string input)
        {
            var trd = input.Split(" ");

            var trade = new Domain.TradeContext.Entities.Trade(double.Parse(trd[0]), trd[1], DateTime.ParseExact(trd[2], "MM/dd/yyyy", CultureInfo.InvariantCulture));

            return trade;
        }
    }
}
