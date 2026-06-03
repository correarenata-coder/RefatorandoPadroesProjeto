using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class MariaEstrela : IEstado
    {
        public EstadoMaria GetEstado()
        {
            return EstadoMaria.ESTRELA;
        }
        public IEstado LevarDano()
        {
            return new MariaPequena();
        }
        public IEstado PegarEstrela()
        {
            return this;
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
