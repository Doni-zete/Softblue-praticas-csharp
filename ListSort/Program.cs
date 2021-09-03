using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            tarefas.Add(new Tarefa() { Descricao = "Lavar louça", Prioridade = Tarefa.Nivel.BAIXA });
            tarefas.Add(new Tarefa() { Descricao = "Lavar chão", Prioridade = Tarefa.Nivel.MEDIA }); ;
            tarefas.Add(new Tarefa() { Descricao = "Fazer compras", Prioridade = Tarefa.Nivel.MEDIA });
            tarefas.Add(new Tarefa() { Descricao = "Lavar roupa", Prioridade = Tarefa.Nivel.ALTA });
            tarefas.Add(new Tarefa() { Descricao = "Varrer calçada", Prioridade = Tarefa.Nivel.BAIXA });

            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

    }
    public class Tarefa
    {
        public enum Nivel

        {
            ALTA = 10,
            MEDIA = 5,
            BAIXA = 0
        }
        public string Descricao { get; set; }
        public Nivel Prioridade { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1})", Descricao, Prioridade);
        }

    }

}



