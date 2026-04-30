# 📘 Capítulo 03 — Java e Paradigma Orientado a Objetos

---
## 📌 Visão Geral

Neste capítulo, são aplicados alguns dos padrões descritos pela **Gangue dos Quatro (GoF)**, avaliando também características da linguagem Java e sua relação com o paradigma orientado a objetos.

> ⚠️ **Observação:** Embora o livro utilize **Java**, os conceitos serão adaptados para **C#** sempre que fizer sentido.

---

## 🧠 Pensamento Orientado a Objetos

### 🔹 Mensagem e Estado

- **Estado**: composto pelos atributos (dados) de um objeto  
- **Comportamento**: definido pelos métodos (ações) do objeto  

O estado de um objeto fica **encapsulado**, sendo um dos principais motivadores da **abstração**.

Para alterar o estado, utilizamos **mensagens**, ou seja, chamadas de métodos.

---

## 🧩 Padrões de Projeto e Orientação a Objetos com C#

O C# é uma linguagem:

- ✔️ Estática (fortemente tipada)  
- ✔️ Orientada a objetos  
- ✔️ Com suporte a herança, polimorfismo e interfaces  

👉 Em linguagens estáticas, precisamos de mais abstrações para garantir flexibilidade.

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


Console.WriteLine(preco); // Saída: 80
```
👉 O mesmo tipo (Livro) assume comportamentos diferentes dependendo da implementação concreta.

"""# ⚙️ Tipagem no C#

## ✔️ Validação em tempo de compilação

- **Detecta erros antes da execução**: O compilador verifica tipos e sintaxe antes do programa rodar.
- **Aumenta a segurança do código**: Garante que os dados sejam manipulados de forma previsível.
- **Exige maior estrutura**: Uso de interfaces, classes e contratos para definir o comportamento do sistema.

---


## ⚖️ “Nem tudo é objeto”


### 🔹 Comparação Java vs C#

**Java:**
- `int` não é objeto.
- `Integer` é objeto.

**C#:**
- `int` é um tipo valor (`struct`).
- Pode ser tratado como objeto via **boxing**.
- 
<pre>
int x = 1;

// boxing (vira objeto)
object obj = x;

// agora você pode usar métodos
Console.WriteLine(obj.ToString());
</pre>

👉 Diferente do Java antigo, em C# você consegue usar métodos como .ToString() direto:

<pre>
int x = 1;
x.ToString(); // ✅ funciona
</pre>

## Polimorfismo
Um mesmo método ou objeto tenha comportamentos diferentes dependendo do contexto.

## Sobrescrita vs Sobrecarga

**Override (sobrescrita)** → Altera o comportamento herdado.

**Overload (sobrecarga)** → Múltiplas versões do mesmo método.

* **Em Java:** `@Override` | **Em C#:** `override`
* **Em Java:** Overload | **Em C#:** Overload

## Tipos de polimorfismo em C#
1. Polimorfismo de sobrescrita (override) — em tempo de execução

Acontece quando uma classe filha redefine um comportamento da classe pai.

<pre>
public class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("Som genérico");
    }
}

public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Latido");
    }
}

public class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}
</pre>

Uso :
<pre>

Animal animal = new Cachorro();
animal.FazerSom(); // Latido

animal = new Gato();
animal.FazerSom(); // Miau}
</pre>

2. Polimorfismo de sobrecarga (overload) — em tempo de compilação

Aqui você tem vários métodos com o mesmo nome, mas com parâmetros diferentes.
<pre>
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}

</pre>

3. Polimorfismo com interfaces
Você trabalha com abstração e não com implementação concreta.
<pre>
public interface IPagamento
{
    void Pagar();
}

public class Cartao : IPagamento
{
    public void Pagar()
    {
        Console.WriteLine("Pagamento com cartão");
    }
}

public class Pix : IPagamento
{
    public void Pagar()
    {
        Console.WriteLine("Pagamento com Pix");
    }
}
</pre>

Uso :

<pre>
IPagamento pagamento = new Pix();
pagamento.Pagar();

</pre>


## Interfaces vs classes abstratas

## Interface (contrato)

Uma interface define o que uma classe deve fazer, mas não diz como.
<pre>
public interface IAnimal
{
    void FazerSom();
}}
</pre>

Implementação:
<pre>
public class Cachorro : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Latido");
    }
}
</pre>

A classe é obrigada a implementar tudo que está na interface.

## Classe Abstrata (base com comportamento)

Uma classe abstrata pode ter:

Métodos com implementação
Métodos sem implementação (abstract) => quando você quer que as classes filhas sejam obrigadas a implementar um comportamento específico.
<pre>
public abstract class Animal
{
    public void Dormir()
    {
        Console.WriteLine("Dormindo...");
    }

    public abstract void FazerSom();
}
</pre>
Implementação:
<pre>
public class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}
</pre>

# 🧩 Quando usar Interface vs Classe Abstrata

| ✔ Use Interface quando: | ✔ Use Classe Abstrata quando: |
|------------------------|-------------------------------|
| Quer desacoplar o sistema | Existe uma relação clara de herança ("é um") |
| Precisa de flexibilidade | Você quer reaproveitar código |
| Diferentes classes sem relação direta precisam ter o mesmo comportamento | Existe comportamento comum |