using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Retangulo
    {
        /*
        3. Crie uma classe chamada “Retângulo” que possua atributos para armazenar a largura e a
        altura. Implemente métodos para calcular a área e o perímetro do retângulo
        */

        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = (Largura + Altura) * 2;
            return perimetro;
        }
    }
}
