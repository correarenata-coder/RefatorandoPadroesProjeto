

using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04
{

    public class ParametrosDeBusca
    {
        public int resultadosPorPagina { get; set; } = 15;
        public Categoria categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca tipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor ordernarPor { get; set; } = OrdenarPor.RELEVANCIA;

       

        public ParametrosDeBusca()
        {
        }

        public ParametrosDeBusca(TipoDeBusca tipoDeBusca)
        {
            this.tipoDeBusca = tipoDeBusca;
        }
    }
}
