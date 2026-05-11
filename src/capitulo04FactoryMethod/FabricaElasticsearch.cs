using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod
{
    public class FabricaElasticsearch : IFabricaDeCriterio
    {
        private readonly ParametrosDeBusca _parametros;

        public FabricaElasticsearch(ParametrosDeBusca parametros)
        {

            _parametros = parametros;
        }

        public CriterioDeBusca CriarCriterio()
        {
            return _parametros.tipoDeBusca switch
            {
                TipoDeBusca.PROMOCIONAL => CriterioPromocional(),
                TipoDeBusca.POR_CATEGORIA => CriterioPorCategoria(),
                _ => CriterioNormal()
            };

           
        }

        private CriterioDeBusca CriterioPorCategoria()
        {
            return new CriterioDeBusca
            {
                Paginacao = 30,
                Categoria = Categoria.TUDO,
                OrdenarPor = OrdenarPor.PRECO,
                engine = Engine.ElasticSearch
            };
        }

        private CriterioDeBusca CriterioPromocional()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = Categoria.EM_PROMOCAO,
                OrdenarPor = OrdenarPor.RECENTE,
                engine = Engine.ElasticSearch
            };
        }

        private CriterioDeBusca CriterioNormal()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor,
                engine = Engine.ElasticSearch
            };
        }
    }
}
