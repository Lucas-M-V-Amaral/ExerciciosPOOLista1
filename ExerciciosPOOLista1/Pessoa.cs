using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Pessoa
    {
        /*                      EXERCICIOS POO – PARTE 2
        1. Crie uma classe chamada “Pessoa” que possua atributos para armazenar nome, idade e
        profissão. Implemente métodos para calcular a idade em anos bissextos e exibir
        informações da pessoa. 
        */

        public string Nome { get; set; }
        public int Idade { get; set;}
        public string Profissao { get; set; }

        public Pessoa(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
        }

        public void CalculaIdadeBissextos()
        {
            int anoAtual = int.Parse(DateTime.Now.ToString("yyyy"));
            int anoDeNascimento = anoAtual - Idade;
            int quantBissextos = 0;

            for (int i = anoDeNascimento; i <= anoAtual; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 != 0)
                    {
                        quantBissextos++;
                    }
                    else if (i % 100 == 0 && i % 400 == 0)
                    {
                        quantBissextos++;
                    }
                }
            }
            Console.WriteLine($"Durante sua vida você passou por {quantBissextos} anos bissextos.");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos e trabalha como {Profissao}.");
        }
    }
}
