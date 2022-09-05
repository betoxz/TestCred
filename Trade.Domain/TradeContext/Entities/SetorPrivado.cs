using System;
using System.Collections.Generic;
using System.Text;
using Trade.Domain.TradeContext.Enuns;
using Trade.Domain.TradeContext.Interfaces;

namespace Trade.Domain.TradeContext.Entities
{
    public class SetorPrivado : ISetor
    {
        const double valorCorte = 1000000;
        public string getCategoria(double valor)
        {
            if (valor > valorCorte)
                return RiscoEnum.HighRisk.ToString().ToUpper();
            else
                return RiscoNaoImplementado.NotImplemented.ToString().ToUpper();
        }
    }
}
