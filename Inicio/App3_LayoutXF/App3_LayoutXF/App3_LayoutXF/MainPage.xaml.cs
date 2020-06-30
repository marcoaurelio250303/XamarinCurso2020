using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3_LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void GoPageGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        private void GoPageStack(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
        private void GoPageAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        private void GoPageRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        private void GoPageScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
