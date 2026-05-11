using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capitulo05_Refatorado
{
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
}
