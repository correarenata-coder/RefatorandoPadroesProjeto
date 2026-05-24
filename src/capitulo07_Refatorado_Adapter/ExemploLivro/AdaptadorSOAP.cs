using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo07_Refatorado_Adapter.ExemploLivro
{
    public class AdaptadorSOAP
    {        
        private readonly ClienteSoap _clienteSoap;

        public AdaptadorSOAP( ClienteSoap clienteSoap)
        {           
            _clienteSoap = clienteSoap;
        }

        public PreferenciasCliente GetPreferenciasCliente(string idUniversal)
        {
            var emailsXml =
               _clienteSoap.ObterPreferenciasEmail(idUniversal);

            var emails = string.IsNullOrWhiteSpace(emailsXml)
                ? new List<string>()
                : emailsXml.Split(',').ToList();

            var cartao =
                _clienteSoap.ObterPreferenciasCartao(idUniversal) ?? "";

            var telefonesXml =
                _clienteSoap.ObterPreferenciasTelefone(idUniversal);

            var telefones = string.IsNullOrWhiteSpace(telefonesXml)
                ? new List<string>()
                : telefonesXml.Split(',').ToList();

            var endereco =
                _clienteSoap.ObterPreferenciasEndereco(idUniversal) ?? "";

            var preferenciasCliente = new PreferenciasCliente(
                emails,
                endereco,
                telefones,
                cartao);
            return preferenciasCliente;
        }
    }
}
