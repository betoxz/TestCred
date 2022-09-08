using System;
using System.Collections.Generic;

namespace Trade.Domain.TradeContext.Entities
{
    public class Portfolio
    {
        public List<Trade> trades { get; set; }
        public DateTime ReferenceDate { get; set; }

        private Categoria _categorias;

        public List<string> getCategorias()
        {
            _categorias = new Categoria();

            foreach (Trade td in trades)
                _categorias.Categorias.Add(td.getCateroria(this.ReferenceDate));

            return _categorias.Categorias;
        }
    }
}
