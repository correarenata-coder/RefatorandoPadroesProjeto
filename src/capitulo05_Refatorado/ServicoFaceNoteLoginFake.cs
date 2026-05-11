using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05_Refatorado
{
    public class ServicoFaceNoteLoginFake : ServicoFaceNoteLogin
    {
        public override ResultadoAutenticacao Autenticar(string idUsuario)
        {
            if (idUsuario == "Gil")
            {
                return ResultadoAutenticacao.Sucesso;
            } else if ((idUsuario == "Ana"))
            {
                return ResultadoAutenticacao.Revogado;
            }

            return ResultadoAutenticacao.Falha;
        }
    }
}
