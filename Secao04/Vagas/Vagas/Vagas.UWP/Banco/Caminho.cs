using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Banco.Interfaces;
using Vagas.UWP.Banco;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
           => Path.Combine(ApplicationData.Current.LocalFolder.Path, NomeArquivoBanco);
    }
}
