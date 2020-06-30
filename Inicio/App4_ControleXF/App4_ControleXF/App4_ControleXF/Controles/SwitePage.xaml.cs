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
    public partial class SwitePage : ContentPage
    {
        public SwitePage()
        {
            InitializeComponent();
        }
        private void ActionTrocou(object sender, ToggledEventArgs args)
        {
            lglTrocou.Text = DateTime.Now.ToString("HH:mm") + "-" + args.Value;
        }
    }
}