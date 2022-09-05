using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trade.Domain.TradeContext.Entities;

namespace Trade.Tests
{
    [TestClass]
    public class TestesTrades
    {
        [TestMethod]
        public void ValidaCategoriasExemplo()
        {
            Portfolio portifolio = new Portfolio();

            portifolio.trades = new List<Trade.Domain.TradeContext.Entities.Trade>
            {
                new Domain.TradeContext.Entities.Trade(2000000, "Private", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(400000, "Public", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(500000, "Public", DateTime.Now),
                new Domain.TradeContext.Entities.Trade(3000000, "Public", DateTime.Now)
            };

            IList<string> tradeCategories = new List<string> { "HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK" };

            var retorno = portifolio.getCategorias().ToArray();

            Assert.AreEqual(true, retorno.SequenceEqual(tradeCategories));
        }
    }
}
