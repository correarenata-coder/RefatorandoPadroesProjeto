using capitulo04_FactoryMethod.ExemploLivro.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace capitulo04_FactoryMethod.ExemploLivro.Model
{
    public class CriterioDeBusca
    {
        public int Paginacao { get; set; }

        public Categoria Categoria { get; set; }

        public OrdenarPor OrdenarPor { get; set; }

        public Engine Engine { get; set; }


        public CriterioDeBusca(
       int paginacao,
       Categoria categoria,
       OrdenarPor ordenacao,
       Engine engine)
        {
            Paginacao = paginacao;
            Categoria = categoria;
            OrdenarPor = ordenacao;
            Engine = engine;
        }

        public override string ToString()
        {
            return $"""
            Paginacao: {Paginacao.ToString()}
            Categoria: {Categoria}
            Ordenação: {OrdenarPor}
            Limite: {Engine}
            """;
        }
    }
}
