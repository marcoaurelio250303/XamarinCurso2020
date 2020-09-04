using App1_Cell.Models;
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
    public partial class ImageCeallPage : ContentPage
    {
        public ImageCeallPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente da Empresa" , Foto= "http://helpsaw.trixti.com.br/helpsaw_administrador/Administrador/business_user.png" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas", Foto = "http://helpsaw.trixti.com.br/helpsaw_administrador/Administrador/business_user.png" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing",  Foto = "http://helpsaw.trixti.com.br/helpsaw_administrador/Administrador/business_user.png" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador", Foto = "http://helpsaw.trixti.com.br/helpsaw_administrador/Administrador/business_user.png" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor", Foto = "http://helpsaw.trixti.com.br/helpsaw_administrador/Administrador/business_user.png" });


            ListaFuncionario.ItemsSource = Lista;
        }

    }
}