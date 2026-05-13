using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro
{
    public class FabricaSolr : IFabricaDeCriterio
    {
        private readonly ParametrosDeBusca _parametros;

        public FabricaSolr(ParametrosDeBusca parametros)
        {
            _parametros = parametros;
        }

        public CriterioDeBusca CriarCriterio()
        {
            if (_parametros.tipoDeBusca == TipoDeBusca.PROMOCIONAL)
                return CriterioPromocional();

            if (_parametros.tipoDeBusca == TipoDeBusca.POR_CATEGORIA)
                return CriterioPorCategoria();

            return CriterioNormal();
        }

        private CriterioDeBusca CriterioNormal()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor,
                engine = Engine.Solr
            };
        }

        private CriterioDeBusca CriterioPromocional()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = Categoria.EM_PROMOCAO,
                OrdenarPor = OrdenarPor.RECENTE,
                engine = Engine.Solr
            };
        }

        private CriterioDeBusca CriterioPorCategoria()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor,
                engine = Engine.Solr
            };
        }
    }
}
