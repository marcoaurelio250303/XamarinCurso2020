using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        List<string> empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();
            empresasTI = new List<string>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Patrus");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");
            Preencher(empresasTI);

        }
        private void Preencher(List<String> empresas)
        {
            listResult.Children.Clear();
            foreach (var emp in empresas)
            {
                listResult.Children.Add(new Label { Text = emp });
            }
        }
        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }
        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<String>();
            Preencher(resultado);
        }

    }
}
