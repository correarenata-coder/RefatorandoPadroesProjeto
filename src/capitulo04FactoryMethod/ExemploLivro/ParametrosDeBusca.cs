using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro
{
    public class ParametrosDeBusca
    {
        public int resultadosPorPagina { get; set; } = 15;
        public Categoria categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca tipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor ordernarPor { get; set; } = OrdenarPor.RELEVANCIA;

        public Engine Engine { get; set; } = Engine.ElasticSearch;


        public ParametrosDeBusca()
        {
        }

        public ParametrosDeBusca(TipoDeBusca tipoDeBusca, Engine Engine)
        {
            this.tipoDeBusca = tipoDeBusca;
            this.Engine = Engine;
        }
    }
}
