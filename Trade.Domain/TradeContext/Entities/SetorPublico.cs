using System;
using System.Collections.Generic;
using System.Text;
using Trade.Domain.TradeContext.Enuns;
using Trade.Domain.TradeContext.Interfaces;

namespace Trade.Domain.TradeContext.Entities
{
    public class SetorPublico : ISetor
    {
        const double valorCorte = 1000000;
        public string getCategoria(double valor)
        {
            return valor > valorCorte ? RiscoEnum.MediumRisk.ToString().ToUpper() : RiscoEnum.HighRisk.ToString().ToUpper();
        }
    }
}
