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
    public partial class ImagePage2 : ContentPage
    {
        public ImagePage2()
        {
            InitializeComponent();

            Image imageUsb = new Image();
            imageUsb.Source = ImageSource.FromFile("pendrive.png");
            container.Children.Add(imageUsb);
        }
    }
}