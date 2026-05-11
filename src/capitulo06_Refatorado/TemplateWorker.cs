using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06_RefatoradoTemplate
{
    public abstract class TemplateWorker
    {
        public T Executar<T> (object parametros)
        {
            AntesExecucao(parametros);

            T resultado = ValorPadraoDeRetorno<T>();

            do
            {
                try
                {
                    resultado = Trabalhar<T>(parametros);
                }
                catch (TimeoutException ex)
                {
                    TrataExcecao(ex);
                }

            } while (DeveContinuarTentando());

            return resultado;
        }

        protected virtual  void AntesExecucao(object parametros)
        {
        }

        protected abstract T ValorPadraoDeRetorno<T>();
      

        protected abstract T Trabalhar<T>(object parametros);

        protected abstract void TrataExcecao(TimeoutException ex);

        protected abstract bool DeveContinuarTentando();
    }
}
