using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod
{
    public class FabricaDeBusca
    {
        public static IFabricaDeCriterio Criar(ParametrosDeBusca parametros)
        {
            if (parametros.Engine == Engine.ElasticSearch)
                return new FabricaElasticsearch(parametros);

            if (parametros.Engine == Engine.Solr)
                return new FabricaSolr(parametros);



            throw new InvalidOperationException("Engine não suportada.");
        }
    }
}
