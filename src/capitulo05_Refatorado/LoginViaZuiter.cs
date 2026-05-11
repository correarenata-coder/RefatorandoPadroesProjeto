using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace capitulo05_Refatorado
{
    public class LoginViaZuiter
    {
        public virtual RespostaLogin Autenticar(string usuario)
        {

            // implementação
            return new RespostaLogin("ok", true);
        }

    }
}
