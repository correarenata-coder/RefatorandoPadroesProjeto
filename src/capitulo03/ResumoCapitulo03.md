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
Igual ao Java
<pre>
object variavel = "texto";
variavel = 10;
variavel = new Cliente();
</pre>
👉 Mesmo conceito: Um tipo genérico (object)pode referenciar qualquer tipo específico (string, int, Cliente).

💡 Exemplo mais real
<pre>
List<string> lista = new List<string>();
lista.Add("teste");

// trocando implementação
IList<string> lista2 = new List<string>();
</pre>

## Sobrescrita vs Sobrecarga

**Override (sobrescrita)** → Altera o comportamento herdado.

**Overload (sobrecarga)** → Múltiplas versões do mesmo método.

* **Em Java:** `@Override` | **Em C#:** `override`
* **Em Java:** Overload | **Em C#:** Overload
* 
<pre>
public class Estudante
{
    public string Nome { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}";
    }
}
</pre>

Chamando o comportamento original
<pre>

public override string ToString()
{
    var original = base.ToString();
    return $"Nome: {Nome} | {original}";
}
</pre>

## Interfaces e classes abstratas
<pre>
public interface IArma
{
    int GetDano();
    int GetBonusVelocidade();
}
</pre>

Implementação:
<pre>
public class Adaga : IArma
{
    public int GetDano() => 10;
    public int GetBonusVelocidade() => 3;
}
</pre>

## Classe abstrata
<pre>
public abstract class Arma
{
    public abstract int GetDano();
    public abstract int GetBonusVelocidade();

    public int DanoComArmaQuebrada()
    {
        return GetDano() / 2;
    }
}
</pre>