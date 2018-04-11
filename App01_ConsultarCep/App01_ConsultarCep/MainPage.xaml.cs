using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCep.Servico.Modelo;
using App01_ConsultarCep.Servico.Validacao;
using App01_ConsultarCep.Servico;

namespace App01_ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            buttonBuscar.Clicked += BuscarCep;
            
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            Endereco endereco = new Endereco();
            try
            {
  
                endereco.Cep = entryCep.Text.Trim();
                ValidarCep validaCep = new ValidarCep();
                endereco = validaCep.VerificarCep(endereco);

                //endereco = ViaCepServico.BuscarEnderecoViaCEP(endereco.Cep);
                resultBuscarCep.Text = string.Format("Endereço: {0}\nBairro: {1}\nCidade: {2}\nEstado: {3}", endereco.Logradouro, endereco.Bairro, endereco.Localidade, endereco.Uf);



            }
            catch (Exception e)
            {

                DisplayAlert("Erro",e.Message, "OK");
            }

        }
    }
}
