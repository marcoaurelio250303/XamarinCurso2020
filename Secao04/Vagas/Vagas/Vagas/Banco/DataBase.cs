using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Vagas.Banco.Interfaces;
using Vagas.Models;
using Xamarin.Forms;

namespace Vagas.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            var caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable <Vaga>();
        }

        public void Cadastro(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }
        public void Atualizacao(Vaga vaga)
        {
            _conexao.Update(vaga);
        }
        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }

        public List<Vaga> Consultar(string nomeVaga)
        {
            return _conexao.Table<Vaga>().Where(f => f.NomeVaga == nomeVaga).ToList();
        }

        public Vaga ObterVagaPorId(int id)
        {
            return _conexao.Table<Vaga>().Where(f => f.Id == id).FirstOrDefault();
        }

    }
}
