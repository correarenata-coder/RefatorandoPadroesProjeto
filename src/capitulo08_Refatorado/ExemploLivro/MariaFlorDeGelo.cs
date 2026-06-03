using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class MariaFlorDeGelo : IEstado
    {
        public EstadoMaria GetEstado()
        {
            return EstadoMaria.FLOR_DE_GELO;
        }

        public IEstado LevarDano()
        {
            return new MariaPequena();
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
            return new MariaFlorDeFogo();
        }
    }
}
