using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06_RefatoradoTemplate.ExemploLivro
{
    public class EmailWorker : TemplateWorker
    {
        private readonly ServicoEmail _servicoEmail;
        private int contadorTentativas =0;
        private int limiteTentativas= 3;

        public EmailWorker(ServicoEmail servicoEmail)
        {
            _servicoEmail = servicoEmail;
        }

        //public EmailEnviado Enviar(EnviarEmail enviarEmail)
        //{
        //    Usuario usuario =
        //        BuscarUsuario(enviarEmail.IdUsuario);

        //    string corpoEmail =
        //        GerarCorpoEmail(enviarEmail.TipoEmail, usuario);

        //    string assunto =
        //        GerarAssunto(enviarEmail.TipoEmail, usuario);

        //    EmailEnviado emailEnviado =
        //        new EmailEnviado("", "",new List<string>());

        //    int contadorTentativas = 0;
        //    while (contadorTentativas < limiteTentativas)
        //    {

        //        try
        //        {
        //            List<string> destinatarios =
        //                enviarEmail.Destinatarios;

        //            emailEnviado = _servicoEmail.EnviarEmail(
        //                assunto,
        //                corpoEmail,
        //                destinatarios
        //            );
        //        }
        //        catch (TimeoutException ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }

        //    return emailEnviado;
        //}

        private string GerarCorpoEmail(Email tipoEmail, Usuario usuario)
        {
            return $"Olá {usuario.Nome}";
        }

        private string GerarAssunto(Email tipoEmail, Usuario usuario)
        {
            return $"Convite sobre o 'assunto' enviado por {usuario.Nome}";
        }

        protected override T ValorPadraoDeRetorno<T>()
        {
            return (T)(object)new EmailEnviado("", "", new List<string>());
        }

        protected override T Trabalhar<T>(object parametros)
        {

            EnviarEmail enviarEmail = (EnviarEmail)parametros;
            Usuario usuario = BuscarUsuario(enviarEmail.IdUsuario);

            string corpoEmail =
               GerarCorpoEmail(enviarEmail.TipoEmail, usuario);

            string assunto =
                GerarAssunto(enviarEmail.TipoEmail, usuario);

            EmailEnviado emailEnviado =
                new EmailEnviado(assunto,
            corpoEmail,
            enviarEmail.Destinatarios);

            contadorTentativas = limiteTentativas;

            return (T)(object)emailEnviado;
        }



        private Usuario BuscarUsuario(int idUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>
                {
                    new Usuario(1, "Usuario1","teste@email1"),
                    new Usuario(2, "Maria", "teste@email2"),
                    new Usuario(3, "Carlos" ,"teste@email3")
                };

            return usuarios.First(u => u.Id == idUsuario);
        }

        protected override void AntesExecucao(object parametros)
        {
            limiteTentativas = 5;
            contadorTentativas = 0;
        }
        protected override void TrataExcecao(TimeoutException ex)
        {
            throw new NotImplementedException();
        }
        protected override  bool DeveContinuarTentando()
        {
            return limiteTentativas > contadorTentativas;
        }
    }
}
