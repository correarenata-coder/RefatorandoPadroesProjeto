using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_SimpleFactory
{
    public class CriterioDeBusca
    {
        public int Paginacao { get; set; }

        public Categoria Categoria { get; set; }

        public OrdenarPor OrdenarPor { get; set; }
    }
}
