using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07_Refatorado_Adapter.ExemploLivro
{
    public class PreferenciasCliente
    {
        public List<string> Emails { get; set; }
        public string Endereco { get; set; }
        public List<string> Telefones { get; set; }
        public string Cartao { get; set; }

        public PreferenciasCliente(
            List<string> emails,
            string endereco,
            List<string> telefones,
            string cartao)
        {
            Emails = emails;
            Endereco = endereco;
            Telefones = telefones;
            Cartao = cartao;
        }
    }
}
