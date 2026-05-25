using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo09_RefatoradoBuilder.ExemploLivro
{
    public class CarroValidoBuilder
    {
        private String modelo;
        private String fabricante;
        private int anoFabricacao;
        private String placa;
        private String cor;
        private int kmRodados;
        private int anoModelo;
        private long precoMinimo;
        private long precoAnunciado;
        public CarroValidoBuilder()
        {
            this.modelo = "Modelo	A";
            this.fabricante = "Fabricante	A";
            this.anoFabricacao = 2000;
            this.anoModelo = 2001;
            this.placa = "ABC1234";

        }

        public Carro build()
        {
            Carro carro = new Carro(modelo, fabricante, anoFabricacao,
                                            placa, cor, kmRodados, anoModelo,
                                            precoMinimo, precoAnunciado);
            return carro;
        }


        public CarroValidoBuilder ComCor(string cor)
        {
            this.cor = cor;
            return this;
        }

        public CarroValidoBuilder ComKmRodados(int kmRodados)
        {
            this.kmRodados = kmRodados;
            return this;
        }
    }

}
        
