
using capitulo06.ExemploLivro;
using Capitulo06;

int idUsuario = 1;

var destinatarios = new List<string>
    {
        "email@email.com",
        "outro@email.com",
        "um@email.com"
    };

string assunto = "Convite enviado por Usuario1";

var servicoEmail = new ServicoEmail();
var emailWorker = new EmailWorker(servicoEmail);

var enviarEmail = new EnviarEmail(
    idUsuario,
    Email.Convite,
    destinatarios
);

EmailEnviado email = emailWorker.Enviar(enviarEmail);

Console.WriteLine(email.Destinatarios.SequenceEqual(destinatarios)
    ? "Destinatários OK"
    : "Destinatários incorretos");

Console.WriteLine(email.Assunto == assunto
    ? "Assunto OK"
    : "Assunto incorreto");

Console.WriteLine(email.EmailsEnviados == 3
    ? "Quantidade OK"
    : "Quantidade incorreta");