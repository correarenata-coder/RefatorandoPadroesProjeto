# 📘 Capítulo 03 — Java e Paradigma Orientado a Objetos

---

## 📌 Visão Geral

Este capítulo tem como objetivo aplicar alguns dos padrões descritos pela **Gangue dos Quatro (GoF)**, ao mesmo tempo em que apresenta características importantes da linguagem **Java**.

> ⚠️ **Observação:** Embora o livro utilize **Java**, neste repositório os exemplos e adaptações serão feitos em **C#**.

---

## 🧠 Pensamento Orientado a Objetos

### 🔹 Estado e Comportamento

- **Estado**: representado pelos atributos (dados) de um objeto  
- **Comportamento**: representado pelos métodos (ações) do objeto  

O estado de um objeto é **encapsulado**, ou seja, fica protegido dentro dele — esse é um dos pilares da **abstração**.

Para alterar o estado, utilizamos **mensagens** (chamadas de métodos).

---

## 🧩 Padrões de Projeto e OO com C#

O C# é uma linguagem:

- ✔️ Estática (fortemente tipada)  
- ✔️ Orientada a objetos  
- ✔️ Com suporte a herança, polimorfismo e interfaces  

👉 Em linguagens estáticas, precisamos de mais abstrações para ganhar flexibilidade.

No C#, isso aparece como:

- Interfaces (`IProduto`, `IPagamento`)  
- Classes base (herança)  
- Polimorfismo (`virtual`, `override`)  
- Injeção de dependência  

---

## 💻 Exemplo de Polimorfismo em C#

```csharp
public class Livro
{
    public virtual decimal CalcularPrecoFinal()
    {
        return 100;
    }
}

public class LivroPromocional : Livro
{
    public override decimal CalcularPrecoFinal()
    {
        return 80;
    }
}

// Uso polimórfico
Livro livro = new LivroPromocional();
var preco = livro.CalcularPrecoFinal();