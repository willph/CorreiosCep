using System;
using System.Collections.Generic;
using System.Text;
using App01_ConsultarCep.Servico.Modelo;
using App01_ConsultarCep.Servico.Dados;

namespace App01_ConsultarCep.Servico.Validacao
{
   public class ValidarCep
    {
       
        public void VerificarCep(Endereco endereco)
        {
            int novoCep;

            if (endereco.Cep.Trim().Equals("") == true)
            {

                throw new Exception("Por favor digite o CEP!");

            }
            if (endereco.Cep.Length != 8)
            {
                throw new Exception("O cep deve conter 8 caracteres!");

            }
            if (!int.TryParse(endereco.Cep, out novoCep))
            {
                throw new Exception("O cep deve conter apenas número");
            }
            //DadosCep dadosCep = new DadosCep();
            //dadosCep.BuscarEnderecoViaCEP(endereco);
            ViaCepServico.BuscarEnderecoViaCEP(endereco.Cep);
        }
    }
}
