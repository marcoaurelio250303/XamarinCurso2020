using ListaFacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaFacil.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + "," + DateTime.Now.ToString("MM/yyyy");
            CarregarTarefas();
        }
        public void ActionGoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());

        }
        public void LinhaStakLayout(Tarefa tarefa, int index)
        {
            View StackCentral = null;

            if (tarefa.DataFinalizacao == null)
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome };
            else
            {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, Spacing = 0, HorizontalOptions = LayoutOptions.FillAndExpand };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = $"Finalizado em {tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy hh:mm")}", TextColor = Color.Gray, FontSize = 10 });
            }
            
            Image ImagemDelete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("lixeira.png") };
            if (Device.RuntimePlatform == Device.UWP)
                ImagemDelete.Source = ImageSource.FromFile("lixeira.png");

            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate
            { new GerenciadorTarefa().Deletar(index);
                CarregarTarefas();
            };
            ImagemDelete.GestureRecognizers.Add(DeleteTap);

            Image ImagemCheck = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.jpg")};
            if (Device.RuntimePlatform == Device.UWP)
                ImagemCheck.Source = ImageSource.FromFile("Resource/CheckOff.jpg");
            
            if (tarefa.DataFinalizacao != null)
            {
                ImagemCheck.Source = ImageSource.FromFile("ChekOn.jpg");
                if (Device.RuntimePlatform == Device.UWP)
                {
                    ImagemCheck.Source = ImageSource.FromFile("Resource/ChekOn.jpg");
                }
            }

            TapGestureRecognizer TarefaTap = new TapGestureRecognizer();
            TarefaTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(index,tarefa);
                CarregarTarefas();
            };
            ImagemCheck.GestureRecognizers.Add(TarefaTap);

            Image ImagemTarefa = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile($"p{tarefa.Prioridade.ToString()}.png") };
            if (Device.RuntimePlatform == Device.UWP)
                ImagemTarefa.Source = ImageSource.FromFile($"Resource/p{tarefa.Prioridade.ToString()}.png");


            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };
            Linha.Children.Add(ImagemCheck);
            Linha.Children.Add(StackCentral);
            Linha.Children.Add(ImagemTarefa);
            Linha.Children.Add(ImagemDelete);

            SLTarefas.Children.Add(Linha);

        }
        private void CarregarTarefas()
        {
            SLTarefas.Children.Clear();
            List<Tarefa> Lista = new GerenciadorTarefa().Listagem();
            var i = 0;
            foreach( Tarefa tarefa in Lista)
            {
                LinhaStakLayout(tarefa,i);
                i++;
            }

        }
    }
}