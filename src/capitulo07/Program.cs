using capitulo07.ExemploLivro;
using System.Text.Json;

var idUniversal = "FG123";

var clienteSoap = new ClienteSoap();

var cliente = new Cliente(idUniversal, clienteSoap);

var preferenciasJson = cliente.GetPreferencias();

Console.WriteLine(preferenciasJson);

var preferencias = JsonSerializer.Deserialize<PreferenciasCliente>(
    preferenciasJson);

Console.WriteLine();
Console.WriteLine("Quantidade de emails: " + preferencias?.Emails.Count);

Console.WriteLine("Primeiro email: " +
                  preferencias?.Emails[0]);

Console.WriteLine("Segundo email: " +
                  preferencias?.Emails[1]);