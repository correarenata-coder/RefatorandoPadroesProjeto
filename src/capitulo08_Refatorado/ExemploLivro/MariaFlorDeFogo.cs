using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class MariaFlorDeFogo : IEstado
    {
        public EstadoMaria GetEstado()
        {
            return EstadoMaria.FLOR_DE_FOGO;
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
            return this;
        }

        public IEstado PegarFlorDeGelo()
        {
            return new MariaFlorDeGelo();
        }
    }
}
