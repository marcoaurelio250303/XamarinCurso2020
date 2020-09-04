using App1_Cell.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        public  void GoPagina1(object sender, EventArgs arg)
        {
            Detail = new NavigationPage(new TextCellPage());
        }

        public void GoPagina2(object sender, EventArgs arg)
        {
            Detail = new NavigationPage(new ImageCeallPage());
        }
    }
}