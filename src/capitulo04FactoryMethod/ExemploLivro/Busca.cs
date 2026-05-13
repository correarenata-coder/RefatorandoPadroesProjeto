using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro
{
    public class Busca
    {
        private readonly ServicoDeBusca _servico;

        public Busca(ServicoDeBusca servico)
        {
            _servico = servico;
        }

        public void Por(ParametrosDeBusca parametros)
        {
         

            CriterioDeBusca criterio =
            new FabricaDeCriterio(parametros).CriarCriterio();

          

           var lista=  _servico.RealizarBuscaCom(criterio);

            EncontrarProdutosPorIds(lista);
        }

        private void EncontrarProdutosPorIds(List<string> ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine($"Produto encontrado: {id}");
            }
        }
    }
}
