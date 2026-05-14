using capitulo04_FactoryMethod.ExemploLivro.Criterios;
using capitulo04_FactoryMethod.ExemploLivro.Enum;
using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Factory
{
    public class FabricaDeCriterio
    {
        private readonly ParametrosDeBusca _parametros;

        public class FabricaDeCriterio
        {
            public static ICriadorDeCriterio Criar(TipoDeBusca tipo)
            {
                return tipo switch
                {
                    TipoDeBusca.NORMAL => new CriterioNormal(),

                    TipoDeBusca.PROMOCIONAL => new CriterioPromocional(),

                    _ => throw new NotImplementedException()
                };
            }
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
