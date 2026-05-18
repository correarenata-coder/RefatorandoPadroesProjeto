using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capitulo05_Refatorado.ExemploLivro
{
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
}
