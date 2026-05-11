using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace capitulo05
{
    public class ServicoFaceNoteLogin
    {
        public virtual ResultadoAutenticacao Autenticar(string idUsuario)
        {
            try
            {
                return ResultadoAutenticacao.Sucesso;
            }
            catch (TimeoutException ex)
            {
                return ResultadoAutenticacao.Falha;
            }

           
        }

        
    }
}
