using capitulo09.ExemploLivro;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

int anoFabricacao = 2000;
int anoModelo = 1999;

Carro carroInvalido =
    new Carro(
        "modelo a",
        "fabricante a",
        anoFabricacao,
        "abc1234",
        "",
        0,
        anoModelo,
        0,
        0);

string mensagemDeErro =
    "ano do modelo nao pode ser anterior ao ano de fabricacao";

List<string> erros = carroInvalido.GetErros();

bool resultado = carroInvalido.Validar();

Console.WriteLine("Validação: " + resultado);

erros = carroInvalido.GetErros();

Console.WriteLine("Quantidade de erros: " + erros.Count);

if (erros.Count > 0)
{
    Console.WriteLine("Mensagem de erro:");
    Console.WriteLine(erros[0]);
}

Console.WriteLine();
Console.WriteLine("Teste passou?");

bool testePassou =
    resultado == false &&
    erros.Count == 1 &&
    erros[0] == mensagemDeErro;

Console.WriteLine(testePassou);
