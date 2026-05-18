using capitulo05;
using capitulo05.ExemploLivro;

var servicoFaceNote = new ServicoFaceNoteLoginFake();
var servicoZuiter = new ServicoZuiterLogin();

var login = new Login(servicoFaceNote, servicoZuiter);

string usuario = "Gil";

var dados = new DadosDeLogin(
    Autenticacao.ViaFaceNote,
    usuario
);

RespostaLogin respostaLogin = login.Com(dados);

string mensagemSucesso = "login com sucesso";

Console.WriteLine($"Status: {respostaLogin.Status}");
Console.WriteLine($"Mensagem: {respostaLogin.Mensagem}");
Console.WriteLine();

Console.WriteLine(respostaLogin.Status == true
    ? "Status OK"
    : "Status incorreto");

Console.WriteLine(respostaLogin.Mensagem == mensagemSucesso
    ? "Mensagem OK"
    : "Mensagem incorreta");