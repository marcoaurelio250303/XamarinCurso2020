﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App2_TipoPaginaXF.TipoPasta.Caroucel.IntroducaoApp();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
