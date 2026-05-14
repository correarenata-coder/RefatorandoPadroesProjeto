using capitulo04_FactoryMethod.ExemploLivro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Criterios
{
    public class CriadorDeBuscaPromocional : ICriadorDeCriterio
    {
        public CriterioDeBusca Criar(ParametrosDeBusca parametros)
        {
            return new CriterioDeBusca(
                parametros.ResultadosPorPagina,
                parametros.Categoria,
                Enum.OrdenarPor.RECENTE,
                Enum.Engine.ElasticSearch
            );
        }
    }
    {
    }
}
