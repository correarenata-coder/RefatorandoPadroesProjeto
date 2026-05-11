using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06_RefatoradoTemplate
{
    public class EnviarEmail
    {
        public int IdUsuario { get; set; }

        public Email TipoEmail { get; set; }

        public List<string> Destinatarios { get; set; }

        public EnviarEmail(
            int idUsuario,
            Email tipoEmail,
            List<string> destinatarios)
        {
            IdUsuario = idUsuario;
            TipoEmail = tipoEmail;
            Destinatarios = destinatarios;
        }
    }
}
