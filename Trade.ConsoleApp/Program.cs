using System;
using System.Collections.Generic;
using System.Linq;
using Trade.Domain.TradeContext.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Trade.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio portifolio = new Portfolio();

            //Trades de entrada
            portifolio.trades = new List<Trade.Domain.TradeContext.Entities.Trade>
            {
                new Domain.TradeContext.Entities.Trade(2000000, "Private", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(400000, "Public", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(500000, "Public", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(3000000, "Public", DateTime.Now)
            };

            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var TradesEntrada = JsonSerializer.Serialize(portifolio.trades, options);
            Console.WriteLine("Trades de Entrada = {0}", TradesEntrada);

            Console.WriteLine("\n");
            //Resultado esperado
            var Saida = JsonSerializer.Serialize(portifolio.getCategorias().ToList());

            Console.WriteLine("Categorias de Saída = {0}", Saida);

            Console.ReadKey();
        }
    }
}
