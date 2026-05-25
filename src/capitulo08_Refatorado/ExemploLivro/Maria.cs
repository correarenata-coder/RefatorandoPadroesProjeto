using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class Maria
    {
        private IEstado estadoAtual;
        public Maria()
        {
            this.estadoAtual = new MariaPequena();


        }

        public void pegarFlorDeGelo()
        {
            estadoAtual = estadoAtual.PegarFlorDeGelo();
        }

        public void PegarFlorDeFogo()
        {
            estadoAtual = estadoAtual.PegarFlorDeFogo();
        }
        public void pegarEstrela()
        {
            estadoAtual = estadoAtual.PegarEstrela();
        }
        public void levarDano()
        {
            estadoAtual = estadoAtual.LevarDano();
        }
        public EstadoMaria getEstadoAtual()
        {
            return estadoAtual.GetEstado();

        }
    }
}
