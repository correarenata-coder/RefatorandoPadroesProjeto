using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06_RefatoradoTemplate.ExemploLivro
{
    public class EmailEnviado
    {
        public List<string>? Destinatarios { get; set; }
        public string? Assunto { get; set; }

        public string? Corpo { get; set; }
        public int EmailsEnviados { get; set; }

        public EmailEnviado(string assunto, string corpo, List<string> destinatarios)
        {
            Assunto = assunto;
            Destinatarios = destinatarios;
            EmailsEnviados = destinatarios.Count;
            Corpo = corpo;
        }
    }
}
