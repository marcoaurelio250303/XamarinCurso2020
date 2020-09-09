using App1_Cell.Models;
using App1_Cell.Pages.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });


            ListaFuncionario.ItemsSource = Lista;
        }
        private void ItemSelecionadoAction(object sender , SelectedItemChangedEventArgs args)
        {
            var func = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new DetailPage(func));
        }
        public void FeriasAction(object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            var func = (Funcionario)botao.CommandParameter;

            DisplayAlert($"Titulo: {func.Nome}", $"Mensagem : {func.Nome} - {func.Cargo}", "OK");
        }
        public void AbonoAction(object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            var func = (Funcionario)botao.CommandParameter;

            DisplayAlert($"Titulo: {func.Nome}", $"Mensagem : {func.Nome} - {func.Cargo}", "OK");

        }
    }
}