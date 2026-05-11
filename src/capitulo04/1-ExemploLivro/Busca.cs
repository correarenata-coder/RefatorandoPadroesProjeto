using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04
{
    public class Busca
    {
        private ServicoDeBusca servicoDeBusca;
        public Busca(ServicoDeBusca servicoDeBusca)
        {
            this.servicoDeBusca = servicoDeBusca;
        }
        public void por(ParametrosDeBusca parametros)
        {
            CriterioDeBusca criterio = criarCriterio(parametros);
            List<String> idsDeResultado =
                            servicoDeBusca.RealizarBuscaCom(criterio);
            EncontrarProdutosPorIds(idsDeResultado);

        }

        public CriterioDeBusca criarCriterio(ParametrosDeBusca parametros)
        {
            var criterio = new CriterioDeBusca
            {
                Paginacao = parametros.resultadosPorPagina,
                Categoria = parametros.categoria
            };
            TipoDeBusca busca = parametros.tipoDeBusca;


            if (busca == TipoDeBusca.PROMOCIONAL)
            {
                //	Busca	promocional	ignora	parâmetros	de	busca
                criterio.Categoria = Categoria.EM_PROMOCAO;
                criterio.OrdenarPor = OrdenarPor.RECENTE;
            }
            else if (busca == TipoDeBusca.POR_CATEGORIA)
            {
                criterio.Categoria = parametros.categoria;

                if (parametros.categoria == Categoria.TUDO)
                {
                    // Se categoria não for especificada, volta para busca normal
                    criterio.OrdenarPor = OrdenarPor.RELEVANCIA;
                }
                else
                {
                    // Se tiver categoria, ordena conforme parâmetro
                    criterio.OrdenarPor = parametros.ordernarPor;
                }
            }
            else
            {   //Busca	normal
                criterio.OrdenarPor = parametros.ordernarPor;
            }
            return criterio;
        }

        private void EncontrarProdutosPorIds(List<string> idsDeResultado)
        {
            foreach (var id in idsDeResultado)
            {
                Console.WriteLine($"Produto encontrado: {id}");
            }
        }
    }
}

