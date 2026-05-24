using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07.ExemploLivro
{
    public class ClienteSoap
    {
        public string? ObterPreferenciasEmail(string id)
        {
            return "teste@email.com,outro@email.com";
        }

        public string? ObterPreferenciasCartao(string id)
        {
            return "Visa";
        }

        public string? ObterPreferenciasTelefone(string id)
        {
            return "13999999999,13988888888";
        }

        public string? ObterPreferenciasEndereco(string id)
        {
            return "Rua XPTO";
        }
    }
}
