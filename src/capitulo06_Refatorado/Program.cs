
using capitulo06_RefatoradoTemplate;

int idUsuario = 1;

List<string> destinatarios = new()
        {
            "email@email.com",
            "outro@email.com",
            "um@email.com"
        };

string assunto = "Convite enviado por Usuario1";

ServicoEmail servicoEmail = new ServicoEmail();
EmailWorker emailWorker = new EmailWorker(servicoEmail);

EnviarEmail enviarEmail = new EnviarEmail(
    idUsuario,
    Email.Convite,
    destinatarios
);


// O executar está na classe TemplateWorker, que EmailWorker está herdando
EmailEnviado email =emailWorker.Executar<EmailEnviado>(enviarEmail);


Console.WriteLine("Assunto: " +email.Assunto);

Console.WriteLine("Corpo: " + email.Corpo);

Console.WriteLine("Destinatários corretos: " +
    (email.Destinatarios.SequenceEqual(destinatarios)));

Console.WriteLine("Assunto correto: " +
    (email.Assunto == assunto));

Console.WriteLine("Quantidade correta: " +
    (email.EmailsEnviados == 3));