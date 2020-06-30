using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppBuscaCEP2.Services;


namespace AppBuscaCEP2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            if (EhValidoCEP())
            {
                try
                {
                    var end = ViaCEPSerice.BuscarEnderecoViaCEP(CEP.Text.Trim());
                    if (end != null)
                       RESULTADO.Text = $"Endereço : {end.Logradouro}, {end.Bairro} de {end.Localidade}, {end.Uf }";
                    else
                       DisplayAlert("ERRO", "Endereço não encontrado endereço para cep informado : "+CEP.Text, "OK");

                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRITICO", e.Message, "OK");
                }

            }
        }
        private bool EhValidoCEP()
        {
            bool valido = true;
            if (CEP.Text == null)
            {
                DisplayAlert("Erro", "CEP inválido! O CEP digite um CEP válido.", "OK");
                valido = false;
                return valido;
            }
            if (CEP.Text.Trim().Length != 8)
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");
                valido = false;
            }
            int novoCEP = 0;
            if (!int.TryParse(CEP.Text, out novoCEP))
            {
                DisplayAlert("Erro", "CEP inválido! O CEP deve composto apenas por numero.", "OK");
                valido = false;
            }
            return valido;
        }
    }
}
