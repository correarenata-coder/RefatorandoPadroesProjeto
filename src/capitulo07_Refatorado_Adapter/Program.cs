
using capitulo07_Refatorado_Adapter.ExemploLivro;
using System.Text.Json;

var idUniversal = "FG123";

var clienteSoap = new ClienteSoap();

var adaptadorSoap =
    new AdaptadorSOAP(clienteSoap);

var cliente = new Cliente(idUniversal, adaptadorSoap);

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