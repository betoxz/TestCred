using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trade.Domain.TradeContext.Entities
{
    public class Portfolio
    {
        public List<Trade> trades { get; set; }

        private Categoria _categorias;

        public List<string> getCategorias()
        {
            _categorias = new Categoria();

            foreach (Trade td in trades)
                _categorias.Categorias.Add(td.getCateroria());

            return _categorias.Categorias;
        }
    }
}
