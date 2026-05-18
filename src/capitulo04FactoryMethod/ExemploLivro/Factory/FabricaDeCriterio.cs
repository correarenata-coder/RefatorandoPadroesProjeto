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

            public static ICriadorDeCriterio Criar(TipoDeBusca tipo)
            {
                return tipo switch
                {
                    TipoDeBusca.NORMAL => new CriadorDeBuscaNormal(),

                    TipoDeBusca.PROMOCIONAL => new CriadorDeBuscaPromocional(),

                    _ => throw new NotImplementedException()
                };
            }
        
    }
}
