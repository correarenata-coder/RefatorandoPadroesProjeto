

using capitulo10_Decorator;
using capitulo10_Decorator.ConcreteDecorator;

IPizza pizza = new Pizza();

Console.WriteLine(pizza.Opcionais());
Console.WriteLine($"Preço R$ { pizza.Preco()}\n");
Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadKey();

Console.WriteLine("-----  Aplicando o Decorator -----");

IPizza pizza2 = new Pizza();
IPizza massaEspecial = new MassaExpecialDecorator(pizza2);
IPizza baconDecorator = new MassaExpecialDecorator(massaEspecial);
IPizza bordaDecorator = new MassaExpecialDecorator(baconDecorator);

Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine($"Preço Total R$: { bordaDecorator.Preco()}\n");
Console.ReadKey();