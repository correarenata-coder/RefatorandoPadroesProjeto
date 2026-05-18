# 📘 Capítulo 04 — FACTORY:	GERENCIANDO A	CRIAÇÃO	DE	OBJETOS

---
## 📌 Refatorando o exemplo anterior do capítulo 04

Esse Factory serve para criar o mesmo tipo de produto mas com diferentes fábricas, cad uma funcionando de maneira diferente
---

## Sobre Factory Method
Ideal principal do livro:
1. remover muitos if/else;
2. encapsular criação de objetos;
3. separar regras de negócio da escolha da implementação.

## Tipos de Enumeração
<pre>
public enum TipoDeBusca
{
    Normal,
    Promocional
}



</pre>

##Tipos de Models

<pre>

public class ParametrosDeBusca
    {
        public int ResultadosPorPagina { get; set; } = 15;
        public Categoria Categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca TipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor OrdernarPor { get; set; } = OrdenarPor.RELEVANCIA;

        public Engine Engine { get; set; } = Engine.ElasticSearch;


        public ParametrosDeBusca()
        {
        }

        public ParametrosDeBusca(
        TipoDeBusca tipo,
        int resultadosPorPagina,
        Categoria categoria,
        OrdenarPor ordenacao,
        Engine engine)
        {
            TipoDeBusca = tipo;
            ResultadosPorPagina = resultadosPorPagina;
            Categoria = categoria;
            OrdernarPor = ordenacao;
            Engine = engine;
        }
    }

public class CriterioDeBusca
    {
        public int Paginacao { get; set; }

        public Categoria Categoria { get; set; }

        public OrdenarPor OrdenarPor { get; set; }

        public Engine Engine { get; set; }


        public CriterioDeBusca(
       int paginacao,
       Categoria categoria,
       OrdenarPor ordenacao,
       Engine engine)
        {
            Paginacao = paginacao;
            Categoria = categoria;
            OrdenarPor = ordenacao;
            Engine = engine;
        }

        public override string ToString()
        {
            return $"""
            Paginacao: {Paginacao.ToString()}
            Categoria: {Categoria}
            Ordenação: {OrdenarPor}
            Limite: {Engine}
            """;
        }
    }
</pre>

##Fabrica de Critério
<pre>


 public interface ICriadorDeCriterio
    {
        CriterioDeBusca Criar(ParametrosDeBusca parametros);
    }
</pre>

## Tipos de Imprementações concretas
<pre>

public class CriadorDeBuscaNormal : ICriadorDeCriterio
{
    public CriterioDeBusca Criar(ParametrosDeBusca parametros)
    {
        return new CriterioDeBusca(
            parametros.Termo,
            parametros.Categoria,
            parametros.Ordenacao,
            parametros.Limite
        );
    }
}

public class CriadorDeBuscaPromocional : ICriadorDeCriterio
{
    public CriterioDeBusca Criar(ParametrosDeBusca parametros)
    {
        return new CriterioDeBusca(
            parametros.Termo + " promoção",
            parametros.Categoria,
            "MENOR_PRECO",
            10
        );
    }
}

</pre>


## Fabrica 
<pre>

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
</pre>

## Serviço 