

using capitulo03._1_Polimorfismo;



#region ChamadaPolimorfismo

Livro livro = new LivroPromocional();
var preco = livro.CalcularPrecoFinal();


Console.WriteLine("Resposta é :" + preco); // Saída: 80 

#endregion