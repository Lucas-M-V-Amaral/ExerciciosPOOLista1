using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Circulo
    {
        /* 
        1. Crie uma classe chamada “Círculo” que possua um atributo para armazenar o raio e
        métodos para calcular a área e o perímetro do círculo.
        */

        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            double area = 3.1415 * Raio * Raio;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 3.1415 * Raio * 2;
            return perimetro;
        }
    }
}
