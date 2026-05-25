using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09_RefatoradoBuilder.ExemploLivro
{
    public class Carro
    {
        private string modelo;
        private string fabricante;
        private int anoFabricacao;
        private string placa;
        private string cor;
        private int kmRodados;
        private int anoModelo;
        private decimal precoMinimo;
        private decimal precoAnunciado;

        private List<string> erros = new List<string>();

        public Carro(
            string modelo,
            string fabricante,
            int anoFabricacao,
            string placa,
            string cor,
            int kmRodados,
            int anoModelo,
            decimal precoMinimo,
            decimal precoAnunciado)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.anoFabricacao = anoFabricacao;
            this.placa = placa;
            this.cor = cor;
            this.kmRodados = kmRodados;
            this.anoModelo = anoModelo;
            this.precoMinimo = precoMinimo;
            this.precoAnunciado = precoAnunciado;
        }

        public bool Validar()
        {
            erros.Clear();

            if (anoModelo < anoFabricacao)
            {
                erros.Add("ano do modelo nao pode ser anterior ao ano de fabricacao");
            }

            return erros.Count == 0;
        }

        public List<string> GetErros()
        {
            return erros;
        }
        public string GetCor()
        {
            return cor;
        } 
        public int GetKm()
        {
            return kmRodados;
        }
    }
}
