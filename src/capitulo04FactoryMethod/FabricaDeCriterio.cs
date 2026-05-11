using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod
{
    public class FabricaDeCriterio
    {
        private readonly ParametrosDeBusca _parametros;

        public FabricaDeCriterio(ParametrosDeBusca parametros)
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

        private CriterioDeBusca CriterioNormal()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor
            };
        }

        private CriterioDeBusca CriterioPromocional()
        {
            return new CriterioDeBusca
            {
                Paginacao = 30,
                Categoria = Categoria.TUDO,
                OrdenarPor = OrdenarPor.PRECO
            };
        }

        private CriterioDeBusca CriterioPorCategoria()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = OrdenarPor.RELEVANCIA
            };
        }
    }
}
