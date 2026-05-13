using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.ExemploLivro
{
    public class EmailEnviado
    {
        public List<string>? Destinatarios { get; set; }
        public string? Assunto { get; set; }
        public int EmailsEnviados { get; set; }

        public EmailEnviado(string assunto, List<string> destinatarios)
        {
            Assunto = assunto;
            Destinatarios = destinatarios;
            EmailsEnviados = destinatarios.Count;
        }
    }
}
