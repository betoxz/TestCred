using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
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

            portifolio.ReferenceDate = DateTime.ParseExact("12/11/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture);

            portifolio.trades = new List<Trade.Domain.TradeContext.Entities.Trade>
            {
                new Domain.TradeContext.Entities.Trade(2000000, "Private", DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture)),
                new Domain.TradeContext.Entities.Trade(400000, "Public", DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture)),
                new Domain.TradeContext.Entities.Trade(5000000, "Public", DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture)),
                new Domain.TradeContext.Entities.Trade(3000000, "Public", DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", CultureInfo.InvariantCulture))
            };

            IList<string> tradeCategories = new List<string> { "HIGHRISK", "EXPIRED", "MEDIUMRISK", "MEDIUMRISK" };

            var retorno = portifolio.getCategorias().ToArray();

            Assert.AreEqual(true, retorno.SequenceEqual(tradeCategories));
        }
    }
}
