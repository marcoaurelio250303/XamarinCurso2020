using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Banco;
using Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public List<Vaga> lista { get; set; }
        public ConsultaVagas()
        {
            InitializeComponent();

            var database = new DataBase();
            lista = database.Consultar();
            listaVagas.ItemsSource = lista;
            lblCount.Text = lista.Count.ToString();
        }
        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }
        public void MaisDetalhe(object sender, EventArgs args)
        {
            var lblDetalhe = (Label)sender;
            var vaga = ((TapGestureRecognizer)(lblDetalhe.GestureRecognizers[0])).CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }
        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            listaVagas.ItemsSource = lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();

        }
    }
}