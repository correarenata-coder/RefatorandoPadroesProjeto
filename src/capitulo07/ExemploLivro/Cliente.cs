using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capitulo07.ExemploLivro
{
    public class Cliente
    {

        private readonly string _idUniversal;
        private readonly ClienteSoap _clienteSoap;

        public Cliente(string idUniversal, ClienteSoap clienteSoap)
        {
            _idUniversal = idUniversal;
            _clienteSoap = clienteSoap;
        }

        public string GetPreferencias()
        {
            var emailsXml =
                _clienteSoap.ObterPreferenciasEmail(_idUniversal);

            var emails = string.IsNullOrWhiteSpace(emailsXml)
                ? new List<string>()
                : emailsXml.Split(',').ToList();

            var cartao =
                _clienteSoap.ObterPreferenciasCartao(_idUniversal) ?? "";

            var telefonesXml =
                _clienteSoap.ObterPreferenciasTelefone(_idUniversal);

            var telefones = string.IsNullOrWhiteSpace(telefonesXml)
                ? new List<string>()
                : telefonesXml.Split(',').ToList();

            var endereco =
                _clienteSoap.ObterPreferenciasEndereco(_idUniversal) ?? "";

            var preferenciasCliente = new PreferenciasCliente(
                emails,
                endereco,
                telefones,
                cartao);

            return JsonSerializer.Serialize(preferenciasCliente);
        }
    }
}
