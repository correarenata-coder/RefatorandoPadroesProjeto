using capitulo04_FactoryMethod.ExemploLivro.Criterios;
using capitulo04_FactoryMethod.ExemploLivro.Factory;
using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Services
{
    public class Busca
    {
        private readonly ServicoDeBusca _servico;

        public Busca(ServicoDeBusca servico)
        {
            _servico = servico;
        }

        public CriterioDeBusca Por(ParametrosDeBusca parametros)
        {


            ICriadorDeCriterio criador =
            FabricaDeCriterio.Criar(
                parametros.TipoDeBusca);



            CriterioDeBusca criterio =  criador.Criar(parametros);

            var lista=  _servico.RealizarBuscaCom(criterio);

            EncontrarProdutosPorIds(lista);

            return criterio;
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
