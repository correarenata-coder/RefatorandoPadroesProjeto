# 📘 Capítulo 04 — Factory Method  
Aplicando o exemplo do Balta

🔗 **Referência:**  
https://www.youtube.com/watch?v=k1ua1xYbBNQ

---

## 📌 Visão Geral

Existe uma classe IDocument que diz que o documento pode ser gerado
<pre>

public interface IDocument
{
	void Generate();
}
</pre>
Cria duas classes que implementam a interface IDocument, uma para PDF e outra para Word

<pre>
public class PDFDocument : IDocument
{
	public void Generate()
	{
		Console.WriteLine("Gerando PDF...");
	}
}

public class WordDocument : IDocument
{
	public void Generate()
	{
		Console.WriteLine("Gerando Word...");
	}
}
</pre>

Cria uma classe DocumentCreator que tem um método para criar o documento, mas não sabe qual tipo de documento vai criar, isso é decidido em tempo de execução
<pre>
 public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();

        public void GenerateDocument()
            {
                var document = CreateDocument();
                document.Generate();
        }
    }

</pre>

Faz os criadores concretos que herdam da classe DocumentCreator e implementam o método CreateDocument para retornar o tipo de documento específico
<pre>
public class PDFDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new PDFDocument();
    }
}

public class WordDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
 }
</pre>

Com isso, o código que usa o DocumentCreator pode gerar documentos sem se preocupar com os detalhes de qual tipo de documento está sendo criado, promovendo o desacoplamento e a flexibilidade do sistema.
<pre>
public class Client
{
    public void Main()
    {
        DocumentCreator creator = new PDFDocumentCreator();
        creator.GenerateDocument();
        creator = new WordDocumentCreator();
        creator.GenerateDocument();
    }
}</pre>