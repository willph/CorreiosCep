using System;
using System.Collections.Generic;
using System.Text;
using App01_ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace App01_ConsultarCep.Servico
{
    class ViaCepServico
    {
        private static string EnderecoUrl = "http://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoUrl, cep);

            WebClient webClient = new WebClient();
            string conteudo = webClient.DownloadString(NovoEnderecoURL);

            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return endereco;

        }
    }
}
