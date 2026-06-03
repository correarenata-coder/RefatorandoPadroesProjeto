using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capitulo07_Refatorado_Adapter.ExemploLivro
{
    public class Cliente
    {

        private readonly string _idUniversal;
        private readonly AdaptadorSOAP _adaptadorSoap;

        public Cliente(string idUniversal, AdaptadorSOAP adaptadorSoap)
        {
            _idUniversal = idUniversal;
            _adaptadorSoap = adaptadorSoap;
        }

        public string GetPreferencias()
        {
            PreferenciasCliente preferenciasCliente = _adaptadorSoap.GetPreferenciasCliente(_idUniversal);

            return JsonSerializer.Serialize(preferenciasCliente);
        }

       
    }
}
