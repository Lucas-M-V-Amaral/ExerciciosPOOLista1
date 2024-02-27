using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Produto
    {
        /*
        6. Implemente uma classe chamada “Produto” que possua atributos para armazenar o nome,
        o preço e a quantidade em estoque. Adicione métodos para calcular o valor total em
        estoque e verificar se o produto está disponível.
        */

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double CalcularValorTotal()
        {
            double valorTotal;

            if (Quantidade > 0)
            {
                valorTotal = Preco * Quantidade;
                return valorTotal;
            }
            else
            {
                return 0;
            }
        }

        public void VerificaDisponibilidade()
        {
            if (Quantidade > 0)
            {
                Console.WriteLine($"{Nome} está disponivel no estoque.");
            }
            else
            {
                Console.WriteLine($"{Nome} não está disponivel no estoque.");
            }
        }
    }
}
