using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_SimpleFactory.ExemploLivro
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
            CriterioDeBusca criterio = new FabricaDeCriterio(parametros).criarCriterio();


            List<String> idsDeResultado =
                            servicoDeBusca.RealizarBuscaCom(criterio);
            EncontrarProdutosPorIds(idsDeResultado);

        }



        private void EncontrarProdutosPorIds(List<string> idsDeResultado)
        {
            // Implementação aqui
        }
    }
}
