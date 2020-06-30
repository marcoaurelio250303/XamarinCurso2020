using AppBuscaCEP2.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AppBuscaCEP2.Services
{
    public class ViaCEPSerice
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            var novoEnderecoURL = string.Format(EnderecoURL, cep);
            var wc = new WebClient();
            string conteudo = wc.DownloadString(novoEnderecoURL);
            var end = JsonConvert.DeserializeObject<Endereco>(conteudo);
            if (end.Cep == null)
                return null;
            return end;
        }
    }
}
