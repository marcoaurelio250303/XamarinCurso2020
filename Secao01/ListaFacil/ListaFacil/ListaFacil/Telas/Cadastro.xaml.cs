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
    public partial class Cadastro : ContentPage
    {
        public byte Prioridade { get; set; }
        public Cadastro()
        {
            InitializeComponent();
        }
        public void PrioridadeSelectAction(Object sender, EventArgs args)
        {
            var Stacks = SLPrioridades.Children;
            foreach (var linha in Stacks)
            {
                Label lblPrioridade = ((StackLayout)linha).Children[1] as Label;
                lblPrioridade.TextColor = Color.Gray;
            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource file = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            string prioridade = file.File.ToString().Replace(".png", "").Replace("Replace/", "").Replace("p","") ;
            this.Prioridade = byte.Parse(prioridade);

        }
        public void SalvarAction(object sender, EventArgs args)
        {
            bool ErroExiste = false;
            if (TxtNome.Text == null || TxtNome.Text.Trim().Length <= 0) 
            { 
                ErroExiste = true;
                DisplayAlert("Erro", "Nome não Preenchido", "ok");
            }
            

            if ((this.Prioridade <= 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Prioridade não informada", "ok");

            }

            if (!ErroExiste)
            {
                Tarefa tarefa = new Tarefa
                {
                    Nome = TxtNome.Text.Trim(),
                    Prioridade = this.Prioridade
                };

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
            }

        }
    }

}