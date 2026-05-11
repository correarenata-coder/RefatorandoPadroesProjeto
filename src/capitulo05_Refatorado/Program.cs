
using capitulo05_Refatorado;

var servicoFaceNote = new ServicoFaceNoteLoginFake();

var loginViaFaceNote = new LoginViaFaceNoteFake(servicoFaceNote);
var loginViaZuiter = new LoginViaZuiterFake(servicoFaceNote);

var login = new Login(loginViaFaceNote, loginViaZuiter);

string usuario = "Paula";

var dadosDeLogin = new DadosDeLogin(
    Autenticacao.ViaFaceNote,
    usuario
);

login.Com(dadosDeLogin);

Console.WriteLine(loginViaFaceNote.FoiChamado
    ? "Autenticar foi chamado"
    : "Autenticar não foi chamado");

Console.WriteLine(loginViaFaceNote.UsuarioRecebido == usuario
    ? "Usuário correto"
    : "Usuário incorreto");