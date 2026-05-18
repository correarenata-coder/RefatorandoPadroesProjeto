using capitulo04_FactoryMethod.ExemploLivro.Enum;
using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Services
{
    public class ServicoDeBusca
    {
        public List<string> RealizarBuscaCom(
        CriterioDeBusca criterio)
        {
            switch (criterio.Engine)
            {
                case Engine.Banco:
                    return BuscarNoBanco(criterio);

                case Engine.ElasticSearch:
                    return BuscarNoElastic(criterio);

                default:
                    throw new NotImplementedException();
            }
        }


        private List<string> BuscarNoBanco(
            CriterioDeBusca criterio)
        {
            Console.WriteLine(
                "Busca realizada no BANCO");

            return new List<string>
        {
            "PRODUTO_BANCO_1",
            "PRODUTO_BANCO_2"
        };
        }

        private List<string> BuscarNoElastic(
            CriterioDeBusca criterio)
        {
            Console.WriteLine(
                "Busca realizada no ELASTICSEARCH");

            return new List<string>
        {
            "PRODUTO_ELASTIC_1",
            "PRODUTO_ELASTIC_2"
        };

        }
    }

}
