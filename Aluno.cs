using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Aluno
    {
        /*
        4. Implemente uma classe chamada “Aluno” que possua atributos para armazenar o nome, a
        matrícula e as notas de um aluno. Adicione métodos para calcular a média das notas e
        verificar a situação do aluno (aprovado ou reprovado).
        */

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double Prova1 { get; set; }
        public double Prova2 { get; set; }

        public Aluno(string nome, int matricula, double prova1, double prova2)
        {
            Nome = nome;
            Matricula = matricula;
            Prova1 = prova1;
            Prova2 = prova2;
        }

        public double CalcularMedia()
        {
            double media = (Prova1 + Prova2) / 2;
            return media;
        }

        public void VerificarSituacao()
        {
            double media = CalcularMedia();
            
            if (media > 6)
            {
                Console.WriteLine($"O aluno {Nome} está aprovado.");
            }
            else
            {
                Console.WriteLine($"O aluno {Nome} está reprovado.");
            }
        }


    }
}
