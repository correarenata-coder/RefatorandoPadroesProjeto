using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08_Refatorado.ExemploLivro
{
    public interface IEstado
    {
        IEstado PegarFlorDeGelo();
        IEstado PegarFlorDeFogo();
        IEstado PegarEstrela();
        IEstado LevarDano();

        EstadoMaria GetEstado();
    }
}
