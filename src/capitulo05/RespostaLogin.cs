using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05
{
    public class RespostaLogin
    {
        public string Mensagem { get; set; }

        public bool Status { get; set; }

        public RespostaLogin(string mensagem, bool status)
        {
            Mensagem = mensagem;
            Status = status;
        }
    }
}
