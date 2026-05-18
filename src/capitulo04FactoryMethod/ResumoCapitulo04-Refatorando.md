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
```csharp
public enum TipoDeBusca
{
    Normal,
    Promocional
}



```

##Tipos de Models

```csharp

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
```

##Fabrica de Critério
```csharp


 public interface ICriadorDeCriterio
    {
        CriterioDeBusca Criar(ParametrosDeBusca parametros);
    }
```

## Tipos de Imprementações concretas
```csharp

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

```

## Fabrica 
```csharp

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

```
## Serviço -Busca
```csharp
public class Busca
{
    private readonly ServicoDeBusca _servico;

    public Busca(ServicoDeBusca servico)
    {
        _servico = servico;
    }

    public void Por(ParametrosDeBusca parametros)
    {
        ICriadorDeCriterio criador =
            FabricaDeCriterio.Criar(
                parametros.Tipo);

        CriterioDeBusca criterio =
            criador.Criar(parametros);

        var lista =
            _servico.RealizarBuscaCom(criterio);

        EncontrarProdutosPorIds(lista);
    }

    private void EncontrarProdutosPorIds(
        List<string> ids)
    {
        foreach (var id in ids)
        {
            Console.WriteLine(
                $"Produto encontrado: {id}");
        }
    }
}

```

### No program mudar para

```csharp
var parametros =
    new ParametrosDeBusca(
        TipoDeBusca.PROMOCIONAL,
        10,
        Categoria.TUDO,
        OrdenarPor.RECENTE,
        Engine.Banco);

var servico =
    new ServicoDeBusca();

var busca =
    new Busca(servico);

busca.Por(parametros);
```