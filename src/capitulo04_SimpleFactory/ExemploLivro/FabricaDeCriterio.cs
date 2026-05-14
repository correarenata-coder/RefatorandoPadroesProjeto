using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_SimpleFactory.ExemploLivro
{
    public class FabricaDeCriterio
    {

        private readonly ParametrosDeBusca _parametros;
        public FabricaDeCriterio(ParametrosDeBusca parametros)
        {
            _parametros = parametros;
        }


        public CriterioDeBusca criarCriterio()
        {
            CriterioDeBusca criterio = new CriterioDeBusca();
            TipoDeBusca busca = _parametros.tipoDeBusca;


            if (busca == TipoDeBusca.PROMOCIONAL)
            {
                criterio = new FabricaDeCriterio(_parametros).criterioPromocional();
            }
            else if (busca == TipoDeBusca.POR_CATEGORIA)
            {
                criterio = new FabricaDeCriterio(_parametros).criterioPorCategoria();
            }
            else
            {   //Busca	normal
                criterio = new FabricaDeCriterio(_parametros).criterioNormal();
            }
            return criterio;
        }
        public CriterioDeBusca criterioNormal()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor =OrdenarPor.RELEVANCIA
            };

        }
        public CriterioDeBusca criterioPromocional()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = _parametros.categoria,
                OrdenarPor = OrdenarPor.RECENTE
            };
        }

        public CriterioDeBusca criterioPorCategoria()
        {
            return new CriterioDeBusca
            {
                Paginacao = _parametros.resultadosPorPagina,
                Categoria = Categoria.TUDO,
                OrdenarPor = _parametros.ordernarPor
            };
        }


    }
}
