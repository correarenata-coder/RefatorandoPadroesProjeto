using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class MariaPequena : IEstado
    {
        public EstadoMaria getEstado()
        {
            return EstadoMaria.PEQUENA;
        }

        public EstadoMaria GetEstado()
        {
            return EstadoMaria.PEQUENA;
        }

        public IEstado LevarDano()
        {
            return new MariaMorta();
        }

        public IEstado PegarEstrela()
        {
            return new MariaEstrela();
        }

        public IEstado PegarFlorDeFogo()
        {
            return new MariaFlorDeFogo();
        }

        public IEstado PegarFlorDeGelo()
        {
            return new MariaFlorDeGelo();
        }
    }
}
