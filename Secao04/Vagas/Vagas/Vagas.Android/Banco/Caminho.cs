using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Vagas.Banco.Interfaces;
using System.IO;
using Vagas.Droid.Banco;

[assembly : Dependency(typeof(Caminho))]
namespace Vagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco) 
            => Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),NomeArquivoBanco);
        
    }
}