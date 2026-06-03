# CAPÍTULO	9 - BUILDER:	CONSTRUIR COM	CLASSE


---
## 📌 Visão Geral
O padrão de projeto Builder é um padrão criacional usado para construir objetos complexos passo a passo.

Ele é muito útil quando uma classe possui:

1. muitos parâmetros
2. combinações diferentes
3. objetos opcionais
4. construção complicada


## Projeto
Aplicação de venda de carros onde existem muitos atributos e possuem muita lógica associada


## Escopo do sistema
Ajustar a classe Carro de forma que alguns atributos sejam obrigatórios e outros opcionais, assim não é preciso informar um valor em todos os atribuitos.



### Solução
Ao invés de ter uma classe enorme cheia de atributos
```csharp
public class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }
    public bool ArCondicionado { get; set; }
    public bool TetoSolar { get; set; }
}

var carro = new Carro
{
    Modelo = "Civic",
    Cor = "Preto",
    Ano = 2025,
    ArCondicionado = true,
    TetoSolar = true
};

```

```csharp
public class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }
}

public class CarroBuilder
{
    private readonly Carro carro = new();

    public CarroBuilder ComModelo(string modelo)
    {
        carro.Modelo = modelo;
        return this;
    }

    public CarroBuilder ComCor(string cor)
    {
        carro.Cor = cor;
        return this;
    }

    public CarroBuilder ComAno(int ano)
    {
        carro.Ano = ano;
        return this;
    }

    public Carro Build()
    {
        return carro;
    }
}

var carro = new CarroBuilder()
    .ComModelo("Civic")
    .ComCor("Preto")
    .ComAno(2025)
    .Build();

```

Isso é chamado de ** Fluent Interfac **





## Resumo
### Quando usar:

Use Builder quando:

1. o objeto possui muitos atributos
2. existem muitos opcionais
3. a construção é complexa
4. há validações
5. deseja fluidez na criação

