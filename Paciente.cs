using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Paciente
    {
        /*
        9. Crie uma classe chamada “Paciente” que possua atributos para armazenar o nome, a idade
        e o histórico de consultas de um paciente. Implemente métodos para adicionar uma nova
        consulta ao histórico e exibir as consultas realizadas
        */

        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> Historico { get; set; }

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Historico = new List<string>();
        }

        public void AdicionarConsulta(string novaConsulta)
        {
            Historico.Add(novaConsulta);
        }

        public void ExibirConsultas()
        {
            Console.WriteLine($"Exibindo o histórico de consultas do paciente {Nome}:\n");
            for (int i = 0; i < Historico.Count; i++)
            {
                Console.WriteLine((i + 1) + "- " + Historico[i]);
            }
        }
    }
}
