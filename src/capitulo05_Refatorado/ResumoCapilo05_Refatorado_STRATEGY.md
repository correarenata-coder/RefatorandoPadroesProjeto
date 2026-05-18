# CAPÍTULO	5 STRATEGY:	DIVIDIR	PARA SIMPLIFICAR

---
## 📌 Visão Geral

Nesse exemplo vamos refatorar o código de login utilizando o padrão Strategy, para evitar o crescimento do método de login e facilitar a manutenção do código.
---

# 🛒 Exemplo Prático em C#

## 🔹 Estratégias de Login

Separa a lógica de cada login
```csharp
public class LoginViaFaceNote
    {
        static int FACE_NOTE_SUCESSO = 200;
        static int FACE_NOTE_REVOCADO = 403;
        static int FACE_NOTE_BLOQUEADO = 408;
       private ServicoFaceNoteLogin servicoFaceNote;
        public LoginViaFaceNote(ServicoFaceNoteLogin servicoFaceNote)
        {
            this.servicoFaceNote = servicoFaceNote;
        }
        public virtual RespostaLogin Autenticar(string idUsuario)
        {
            ResultadoAutenticacao resposta = servicoFaceNote.Autenticar(idUsuario);
            string mensagem = "não	foi	possível	autenticar";
            bool status = false;
            if (resposta == ResultadoAutenticacao.Sucesso)
            {
                status = true;
                mensagem = "login	com	sucesso";
            }
            else if (resposta == (ResultadoAutenticacao.Revogado))
            {
                mensagem = "acesso	revocado";
            }
            else if (resposta == ResultadoAutenticacao.Bloqueado)
            {
                mensagem = "acesso	bloqueado";
            }
            return new RespostaLogin(mensagem, status);
        }
    }


    public class LoginViaZuiter
    {
        public virtual RespostaLogin Autenticar(string usuario)
        {

            // implementação
            return new RespostaLogin("ok", true);
        }

    }


```

## 🔹 Contexto de Login

Ajustar o Login
```csharp
public class Login
    {
        private readonly LoginViaFaceNote _loginViaFaceNote;
        private readonly LoginViaZuiter _loginViaZuiter;

        public Login(
         LoginViaFaceNote loginViaFaceNote,
         LoginViaZuiter loginViaZuiter)
        {
            _loginViaFaceNote = loginViaFaceNote;
            _loginViaZuiter = loginViaZuiter;
        }


        public RespostaLogin Com(DadosDeLogin dadosDeLogin)
        {
            Autenticacao metodo = dadosDeLogin.Metodo;
            string usuario = dadosDeLogin.Usuario;

            if (metodo == Autenticacao.ViaFaceNote)
            {
                return _loginViaFaceNote.Autenticar(usuario);
            }
            else if (metodo == Autenticacao.ViaZuiter)
            {
                return _loginViaZuiter.Autenticar(usuario);
            }

            string mensagem = "método de autenticação não especificado";
            bool status = false;

            return new RespostaLogin(mensagem, status);
        }

        

        
    }


```

## 🔹 Contexto de Login
Ao fazer a chamada
```csharp
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

```