using capitulo08_Refatorado.ExemploLivro;

var maria = new Maria();

Console.WriteLine("Estado inicial:");
Console.WriteLine(maria.getEstadoAtual());

maria.pegarFlorDeGelo();

Console.WriteLine("\nApós pegar Flor de Gelo:");
Console.WriteLine(maria.getEstadoAtual());

maria.PegarFlorDeFogo();

Console.WriteLine("\nApós pegar Flor de Fogo:");
Console.WriteLine(maria.getEstadoAtual());

maria.levarDano();

Console.WriteLine("\nApós levar dano:");
Console.WriteLine(maria.getEstadoAtual());

maria.pegarEstrela();

Console.WriteLine("\nApós pegar estrela:");
Console.WriteLine(maria.getEstadoAtual());