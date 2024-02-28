using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Livro
    {
        /*
        10. Implemente uma classe chamada “Livro” com atributos para armazenar o título, o autor e o
        número de páginas do livro. Adicione métodos para emprestar o livro, devolvê-lo e
        verificar se está disponível.
        */

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }
        public bool Disponibilidade { get; set; }

        public Livro(string titulo, string autor, int numPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumPaginas = numPaginas;
            Disponibilidade = true;
        }

        public void EmprestarLivro()
        {
            if (Disponibilidade == true)
            {
                Disponibilidade = false;
            }
        }

        public void DevolverLivro()
        {
            if (Disponibilidade == false)
            {
                Disponibilidade = true;
            }
        }

        public void VerificarDisponibilidade()
        {
            if (Disponibilidade == true)
            {
                Console.WriteLine($"O livro {Titulo} está disponível para emprestimo.");
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} não está disponível para emprestimo.");
            }
        }
    }
}
