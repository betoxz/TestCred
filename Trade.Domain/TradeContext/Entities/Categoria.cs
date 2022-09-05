using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Domain.TradeContext.Entities
{
    public class Categoria
    {
        public List<string> Categorias { get; private set; }

        public Categoria()
        {
            this.Categorias = new List<string>();
        }
    }
}

