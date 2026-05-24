using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo08.ExemploLivro
{
    public class Maria
    {
        private EstadoMaria _estadoAtual;
        public Maria()
        {
            this._estadoAtual = EstadoMaria.PEQUENA;
        }

        public void pegarFlorDeGelo()
        {
            if (_estadoAtual == EstadoMaria.ESTRELA)
            {
                return;
            }
            _estadoAtual = EstadoMaria.FLOR_DE_GELO;
        }
        public void pegarEstrela()
        {
            _estadoAtual = EstadoMaria.ESTRELA;
        }
        public void levarDano()
        {
            if (_estadoAtual == EstadoMaria.ESTRELA)
            {
                return;
            }
            if (_estadoAtual == EstadoMaria.PEQUENA)
            {
                _estadoAtual = EstadoMaria.MORTA;
            }
            else
            {
                _estadoAtual = EstadoMaria.PEQUENA;

            }
        }

        public EstadoMaria GetEstadoAtual()
        {
            return _estadoAtual;
        }
    }
}
