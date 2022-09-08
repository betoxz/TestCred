using System;
using Trade.Domain.TradeContext.Enuns;
using Trade.Domain.TradeContext.Intefaces;

namespace Trade.Domain.TradeContext.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; set;}

        public Trade(double valor, string clienteSetor, DateTime NextPaymentDate)
        {
            this.Value = valor;
            this.ClientSector = clienteSetor;
            this.NextPaymentDate = NextPaymentDate;
        }

        public string getCateroria(DateTime ReferenceDate)
        {
            string retorno;

            if (this.NextPaymentDate < ReferenceDate.AddDays(30))
            {
                retorno =  RiscoEnum.Expired.ToString().ToUpper();
            }
            else
            {
                retorno = this.ClientSector.Equals(SetorEnum.Private.ToString()) ?
                new SetorPrivado().getCategoria(this.Value)
                : new SetorPublico().getCategoria(this.Value);
            }                

            return retorno;
        }
    }
}
