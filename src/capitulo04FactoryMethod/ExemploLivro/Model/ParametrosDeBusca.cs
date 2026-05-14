using capitulo04_FactoryMethod.ExemploLivro.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Model
{
    public class ParametrosDeBusca
    {
        public int ResultadosPorPagina { get; set; } = 15;
        public Categoria Categoria { get; set; } = Categoria.TUDO;
        public TipoDeBusca TipoDeBusca { get; set; } = TipoDeBusca.NORMAL;
        public OrdenarPor OrdernarPor { get; set; } = OrdenarPor.RELEVANCIA;

        public Engine Engine { get; set; } = Engine.ElasticSearch;


        public ParametrosDeBusca()
        {
        }

        public ParametrosDeBusca(
        TipoDeBusca tipo,
        int resultadosPorPagina,
        Categoria categoria,
        OrdenarPor ordenacao,
        Engine engine)
        {
            TipoDeBusca = tipo;
            ResultadosPorPagina = resultadosPorPagina;
            Categoria = categoria;
            OrdernarPor = ordenacao;
            Engine = engine;
        }
    }
}
