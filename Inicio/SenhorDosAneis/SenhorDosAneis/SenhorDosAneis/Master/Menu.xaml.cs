using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SenhorDosAneis.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void GoConteudo(object sender, EventArgs args)
        {
            Detail = new  NavigationPage(new Pages.Personagem((sender as Button).Text));
            IsPresented = false;
        }
    }
}