using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05_Refatorado
{ 
    public class ServicoZuiterLogin
    {
        public ResultadoAutenticacao Autenticar(string idUsuario)
        {
            try
            {
                return ResultadoAutenticacao.Sucesso;
            }
            catch (TimeoutException)
            {
                return ResultadoAutenticacao.Falha;
            }
        }
    }
}
