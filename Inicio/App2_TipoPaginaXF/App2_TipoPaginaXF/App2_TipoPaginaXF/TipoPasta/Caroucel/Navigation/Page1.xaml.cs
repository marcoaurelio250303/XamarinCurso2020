using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPasta.Caroucel.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void MudarParaPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }
        private void ChamarModal(object seder, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }
        private void ChamarMaster(object seder, EventArgs args)
        {
            App.Current.MainPage = new Mater.Master();
        }
    }
}