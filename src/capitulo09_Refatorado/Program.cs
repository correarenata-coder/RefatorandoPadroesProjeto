using capitulo09_RefatoradoBuilder.ExemploLivro;

CarroValidoBuilder builder = new CarroValidoBuilder().ComCor("AZUL").ComKmRodados(1234);

Carro carroValido = builder.build();


bool resultado = carroValido.Validar();



Console.WriteLine("Carro válido? " + resultado);

Console.WriteLine("Cor " + carroValido.GetCor());

Console.WriteLine("Cor " + carroValido.GetKm());


Console.WriteLine("Km " + resultado);

Console.WriteLine();
Console.WriteLine("Teste passou?");

Console.WriteLine(resultado == true);