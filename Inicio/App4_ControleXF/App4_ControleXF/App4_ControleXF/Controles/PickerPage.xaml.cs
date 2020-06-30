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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
            BuscarLista();
        }
        private void ActionMudarIndice(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            txtResultado.Text = obj.SelectedItem.ToString();
        }
        private void BuscarLista()
        {
            lista.Items.Add("Marco");
            lista.Items.Add("Barbara");
            lista.Items.Add("Giovana");
            lista.Items.Add("Fabiana");
            
        }
    }
}