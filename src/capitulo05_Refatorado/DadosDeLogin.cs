using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo05_Refatorado
{
    public class DadosDeLogin
    {
        public Autenticacao Metodo { get; set; }

        public string Usuario { get; set; }

        public DadosDeLogin()
        {
        }

        public DadosDeLogin(Autenticacao metodo, string usuario)
        {
            Metodo = metodo;
            Usuario = usuario;
        }
    }
}
