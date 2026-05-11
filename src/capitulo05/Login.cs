using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capitulo05
{
    public class Login
    {
        private readonly ServicoFaceNoteLogin _servicoFaceNote;
        private readonly ServicoZuiterLogin _servicoZuiter;


        private static int FACE_NOTE_SUCESSO = 200;
        private static int FACE_NOTE_REVOCADO = 403;
        private static int FACE_NOTE_BLOQUEADO = 408;
        private static int ZUITER_SUCESSO = 202;
        private static int ZUITER_PENDENTE = 400;

        public Login(
       ServicoFaceNoteLogin servicoFaceNote,
       ServicoZuiterLogin servicoZuiter)
        {
            _servicoFaceNote = servicoFaceNote;
            _servicoZuiter = servicoZuiter;
        }


        public RespostaLogin Com(DadosDeLogin dadosDeLogin)
        {
            ResultadoAutenticacao resposta = ResultadoAutenticacao.MetodoInvalido;

            if (dadosDeLogin.Metodo == Autenticacao.ViaFaceNote)
            {
                resposta = _servicoFaceNote.Autenticar(dadosDeLogin.Usuario);
            }
            else if (dadosDeLogin.Metodo == Autenticacao.ViaZuiter)
            {
                resposta = _servicoZuiter.Autenticar(dadosDeLogin.Usuario);
            }

            string mensagem = "não foi possível autenticar";
            bool status = false;

            switch (resposta)
            {
                case ResultadoAutenticacao.Sucesso:
                    status = true;
                    mensagem = "login com sucesso";
                    break;

                case ResultadoAutenticacao.Revogado:
                    mensagem = "acesso revogado";
                    break;

                case ResultadoAutenticacao.Bloqueado:
                    mensagem = "acesso bloqueado";
                    break;

                case ResultadoAutenticacao.Pendente:
                    mensagem = "acesso pendente";
                    break;
            }

            return new RespostaLogin(mensagem, status);
        }
    
    }

    
   
}
