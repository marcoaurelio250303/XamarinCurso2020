﻿using System;
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
    public partial class CadastroVagas : ContentPage
    {
        public CadastroVagas()
        {
            InitializeComponent();

        }
        public void SalvarAction(object sender, EventArgs args)
        {
            var vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Telefone = Telefone.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CL";
            vaga.Descricao = Descricao.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Email = Email.Text;
            vaga.Empresa = Empresa.Text;

            var database = new DataBase();
            database.Cadastro(vaga);

            App.Current.MainPage = new NavigationPage(new ConsultaVagas());

        }
    }
}