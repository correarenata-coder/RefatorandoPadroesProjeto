# 📘 Capítulo 03 — Java e Paradigma Orientado a Objetos

---
## 📌 Visão Geral

Este capítulo aplicar	alguns	dos
padrões	descritos	pela	Gangue	dos	Quatros , porém avlia caracteristicas da linguagem Java 


> ⚠️ **Observação:** Embora o livro utilize **Java** vou adaptar o que achar interessante para o C#.
---

## 🧠 Pensamento Orientado a Objetos

** Mensagem e estado ** 

Estado é composto por seus atributos, representam os dados que o objeto possui.O estado de um objeto
fica escondigo e isso é um grando motivador da absração de dados em objetos.
Para acionar as mudanças de estado, o objeto precisa receber mensagens, ou seja, chamar seus métodos. O comportamento de um objeto é definido por seus métodos, que são as ações que ele pode realizar.


## ## 🧩 Padrões de Projeto e Orientação a Objetos com C#

O C# é uma linguagem:

Estática (fortemente tipada)
Orientada a objetos
Com suporte completo a herança, polimorfismo e interfaces

Em linguagens estáticas, você precisa criar mais abstrações para permitir flexibilidade.

👉 Em C#, isso aparece muito como:

Interfaces (IProduto, IPagamento)
Classes base (herança)
Polimorfismo (virtual, override)
Injeção de dependência

💻 Exemplo equivalente em C#

<pre>
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

</pre>


Sobre C# :

1. Validação de tipos antes de executar

✔️ Se aplica 100% ao C#

C# também:

Valida tipos em tempo de compilação
Evita muitos erros antes de rodar
Exige mais estrutura (interfaces, classes, etc.)

2. “Nem tudo é objeto”

✔️ Também se aplica ao C# (com uma diferença importante)

🔹 Em Java:
int não é objeto
Integer é objeto
🔹 Em C#:
int é um tipo valor (struct), não um objeto direto
Mas pode ser tratado como objeto via boxing

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

3. Polimorfismo
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

4. Sobrescrita de métodos  
1. Em Java: @Override C# :override
2. Em java :  overload C# overload

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

Interfaces e classes abstratas
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

Classe abstrata:
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