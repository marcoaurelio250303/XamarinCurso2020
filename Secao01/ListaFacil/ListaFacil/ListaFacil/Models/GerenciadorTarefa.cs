using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaFacil.Models
{
    public class GerenciadorTarefa
    {
        const string TF = "Tarefas";
        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);

            SalvaNoProperties(Lista);
        }
        public void Deletar(int index)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);
            SalvaNoProperties(Lista);

        }
        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }
        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.Now;

            Lista.Add(tarefa);
            SalvaNoProperties(Lista);
        }
        private void SalvaNoProperties(List<Tarefa> lista)
        {
            if (App.Current.Properties.ContainsKey(TF))
                App.Current.Properties.Remove(TF);

            string JasonVal = JsonConvert.SerializeObject(lista);

            App.Current.Properties.Add(TF, JasonVal);
        }
        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey(TF))
            {
                string jsonVal = (string)App.Current.Properties[TF];
                
                List<Tarefa> lista = JsonConvert.DeserializeObject<List<Tarefa>>(jsonVal);

                return lista;
            }
            else
                return new List<Tarefa>();
        }

        

    }
}
