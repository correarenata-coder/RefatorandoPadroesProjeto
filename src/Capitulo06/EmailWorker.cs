using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo06
{
    public class EmailWorker
    {
        private readonly ServicoEmail _servicoEmail;
        private int limiteTentativas;

        public EmailWorker(ServicoEmail servicoEmail)
        {
            _servicoEmail = servicoEmail;
        }

        public EmailEnviado Enviar(EnviarEmail enviarEmail)
        {
            Usuario usuario =
                BuscarUsuario(enviarEmail.IdUsuario);

            string corpoEmail =
                GerarCorpoEmail(enviarEmail.TipoEmail, usuario);

            string assunto =
                GerarAssunto(enviarEmail.TipoEmail, usuario);

            EmailEnviado emailEnviado =
                new EmailEnviado("", new List<string>());

            int contadorTentativas = 0;
            while (contadorTentativas < limiteTentativas)
            {

                try
                {
                    List<string> destinatarios =
                        enviarEmail.Destinatarios;

                    emailEnviado = _servicoEmail.EnviarEmail(
                        assunto,
                        corpoEmail,
                        destinatarios
                    );
                }
                catch (TimeoutException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return emailEnviado;
        }

        private Usuario BuscarUsuario(int idUsuario)
        {
            // implementação
            return new Usuario();
        }

        private string GerarCorpoEmail(Email tipoEmail, Usuario usuario)
        {
            // implementação
            return "";
        }

        private string GerarAssunto(Email tipoEmail, Usuario usuario)
        {
            // implementação
            return "";
        }
    }
}
