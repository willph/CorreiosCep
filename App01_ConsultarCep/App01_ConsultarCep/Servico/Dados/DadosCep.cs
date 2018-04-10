using System;
using System.Collections.Generic;
using System.Text;
using App01_ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace App01_ConsultarCep.Servico.Dados
{
    public class DadosCep
    {

        public void BuscarEnderecoViaCEP(Endereco endereco)
        {
            string EnderecoUrl = "http://viacep.com.br/ws/{0}/json/";
            try
            {
                string NovoEnderecoURL = string.Format(EnderecoUrl, endereco.Cep);

                WebClient webClient = new WebClient();
                string conteudo = webClient.DownloadString(NovoEnderecoURL);

                endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);


            }
            catch (Exception e)
            {

                throw new Exception("Erro: " + e.Message);
            }
        }
    }

}
