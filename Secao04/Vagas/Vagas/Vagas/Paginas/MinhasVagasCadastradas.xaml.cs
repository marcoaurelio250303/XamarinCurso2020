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
    public partial class MinhasVagasCadastradas : ContentPage
    {
        public List<Vaga> lista { get; set; }
        public MinhasVagasCadastradas()
        {
            InitializeComponent();
            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            var database = new DataBase();
            lista = database.Consultar();
            listaVagas.ItemsSource = lista;
            lblCount.Text = lista.Count.ToString();
        }

        public void EditarAction(object sender, EventArgs args)
        {
            var lblEditar = (Label)sender;
            var vaga = ((TapGestureRecognizer)(lblEditar.GestureRecognizers[0])).CommandParameter as Vaga;
            Navigation.PushAsync(new EditarVaga(vaga));
        }
        public void ExcluirAction(object sender, EventArgs args)
        {
            var lblExcluir = (Label)sender;
            var vaga = ((TapGestureRecognizer)(lblExcluir.GestureRecognizers[0])).CommandParameter as Vaga;
            DataBase dataBase = new DataBase();
            dataBase.Exclusao(vaga);
            ConsultarVagas();
        }
    }
}