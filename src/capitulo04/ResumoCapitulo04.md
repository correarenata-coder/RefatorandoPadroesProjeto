# 📘 Capítulo 04 — FACTORY:	GERENCIANDO A	CRIAÇÃO	DE	OBJETOS

---
## 📌 Visão Geral

Neste capítulo, será abordado o padrão de projeto **Factory**, que é um dos padrões mais comuns e úteis para gerenciar a criação de objetos em sistemas orientados a objetos.

---

## 🧩 O que é o padrão Factory?
O padrão Factory é um **padrão de criação** que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

## 🔹 Vantagens do padrão Factory
- **Desacoplamento**: O código cliente não precisa conhecer as classes concretas que estão sendo instanciadas, promovendo um baixo acoplamento.
- **Flexibilidade**: Permite que o sistema seja facilmente estendido para criar novos tipos de objetos sem modificar o código cliente.
- **Centralização da criação de objetos**: Facilita a manutenção e evolução do código, pois a lógica de criação está concentrada em um único lugar.	

# 🛒 Exemplo Prático em C#
## Cenário

Imagine um sistema de e-commerce que possui diferentes tipos de busca de produtos.

Dependendo do tipo de busca, critérios diferentes devem ser aplicados automaticamente.

---

# 🎯 1. Definir os tipos diferentes de busca

O sistema deverá suportar:

- busca normal;
- busca por categoria;
- busca promocional.
- 
<pre>
public enum TipoDeBusca
    {
        NORMAL, POR_CATEGORIA, PROMOCIONAL
    }
</pre>

# 📌 2. Regras da Busca

Cada tipo de busca possui comportamentos específicos.

---
## 🔹 Campos da busca
A busca poderá possuir:

| Campo | Descrição |
|---|---|
| Categoria | Categoria dos produtos |
| QuantidadePorPagina |  Quantidade de produtos exibidos por página, sendo 15 padrão |
| Ordem | Ordem de exibição dos produtos |

---
# 📌 3. Regras de negócio

## 🔹 Busca Normal

- Apenas o nome do produto é obrigatório;
- A ordenação padrão será por relevância;
- Quantidade padrão por página: **15 itens**.

---

## 🔹 Busca por Categoria

- Deve informar a categoria;
- Caso a ordenação não seja especificada, utilizar:
  - `"MaisRecentes"`.

---

## 🔹 Busca Promocional

- A ordenação será sempre:
  - `"MaisRecentes"`;
- Outros valores de ordenação devem ser ignorados.

---
# 📌 Estrutura Inicial da Classe de Parâmetros

```csharp
 public class ParametrosDeBusca
    {
        public int resultadosPorPagina { get; set; } = 15;
        public Categoria categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca tipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor ordernarPor { get; set; } = OrdenarPor.RELEVANCIA;
    }
```

# 📌 Outras enumerações necessárias
<pre>
public enum Categoria
    {
        TUDO, EM_PROMOCAO, ELETRONICOS
    }
</pre>


<pre>
public enum OrdenarPor
    {
        RECENTE, PRECO, RELEVANCIA, NAO_ESPECIFICADO
    }
</pre>


# 📌 Problema Sem Factory

Sem utilizar Factory, o código tende a ficar assim:

```csharp
if (parametros.Tipo == TipoDeBusca.NORMAL)
{
    return new BuscaNormal();
}
else if (parametros.Tipo == TipoDeBusca.POR_CATEGORIA)
{
    return new BuscaPorCategoria();
}
else
{
    return new BuscaPromocional();
}
```

Com o crescimento do sistema:

- o código fica difícil de manter;
- regras começam a se espalhar;
- novas buscas exigem alterações em vários pontos.

---

# 🏭 Aplicando o Factory

## 📌 Interface Base

```csharp
public interface ICriterioDeBusca
{
    string Montar();
}
```

---

# 📌 Implementação: Busca Normal

```csharp
public class BuscaNormal : ICriterioDeBusca
{
    public string Montar()
    {
        return "Busca ordenada por relevância";
    }
}
```

---

# 📌 Implementação: Busca por Categoria

```csharp
public class BuscaPorCategoria : ICriterioDeBusca
{
    public string Montar()
    {
        return "Busca por categoria ordenada por mais recentes";
    }
}
```

---

# 📌 Implementação: Busca Promocional

```csharp
public class BuscaPromocional : ICriterioDeBusca
{
    public string Montar()
    {
        return "Busca promocional ordenada por mais recentes";
    }
}
```

---

# 📌 Criando a Factory

```csharp
public static class FabricaDeBusca
{
    public static ICriterioDeBusca Criar(TipoDeBusca tipo)
    {
        return tipo switch
        {
            TipoDeBusca.NORMAL => new BuscaNormal(),

            TipoDeBusca.POR_CATEGORIA => new BuscaPorCategoria(),

            TipoDeBusca.PROMOCIONAL => new BuscaPromocional(),

            _ => throw new ArgumentException("Tipo inválido")
        };
    }
}
```

---

# 📌 Utilizando a Factory

```csharp
class Program
{
    static void Main()
    {
        var criterio = FabricaDeBusca.Criar(TipoDeBusca.PROMOCIONAL);

        Console.WriteLine(criterio.Montar());
    }
}
```

---

# ✅ Benefícios Obtidos

Após aplicar Factory:

- o código ficou mais organizado;
- regras ficaram centralizadas;
- novas buscas podem ser adicionadas facilmente;
- o sistema ficou desacoplado;
- a manutenção ficou mais simples.

---

# 📌 Conclusão

O padrão Factory é uma solução elegante para cenários onde a criação de objetos varia conforme regras de negócio.

Ele ajuda a:

- reduzir acoplamento;
- melhorar manutenção;
- facilitar expansão;
- organizar responsabilidades.