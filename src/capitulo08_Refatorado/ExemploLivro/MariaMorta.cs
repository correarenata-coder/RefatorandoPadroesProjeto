using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public class MariaMorta : IEstado
    {
        public EstadoMaria GetEstado()
        {
            return EstadoMaria.MORTA;
        }
        public IEstado LevarDano()
        {
            return this;
        }
        public IEstado PegarEstrela()
        {
            return this;
        }
        public IEstado PegarFlorDeFogo()
        {
            return this;
        }
        public IEstado PegarFlorDeGelo()
        {
            return this;
        }
    
    }
}
