using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_SimpleFactory
{
    public class FabricaDeCriterio
    {

        private readonly ParametrosDeBusca _parametros;
        public FabricaDeCriterio(ParametrosDeBusca parametros)
        {
            _parametros = parametros;
        }
        public CriterioDeBusca criterioNormal()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor
            };

        }
        public CriterioDeBusca criterioPromocional()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = OrdenarPor.PRECO
            };
        }

        public CriterioDeBusca criterioPorCategoria()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = _parametros.ordernarPor
            };
        }

        public CriterioDeBusca criarCriterio()
        {
            TipoDeBusca busca = _parametros.tipoDeBusca;

            if (busca == TipoDeBusca.PROMOCIONAL)
            {
                return criterioPromocional();
            }
            else if (busca == TipoDeBusca.POR_CATEGORIA)
            {
                return criterioPorCategoria();
            }
            else
            {
                return criterioNormal();
            }


        }
    }
}
