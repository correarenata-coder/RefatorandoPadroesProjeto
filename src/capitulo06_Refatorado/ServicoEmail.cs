using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06_RefatoradoTemplate
{
    public class ServicoEmail
    {
        public virtual EmailEnviado EnviarEmail(
        string assunto,
        string corpoEmail,
        List<string> destinatarios)
        {
            return new EmailEnviado(assunto, corpoEmail, destinatarios);
        }
    }
}
