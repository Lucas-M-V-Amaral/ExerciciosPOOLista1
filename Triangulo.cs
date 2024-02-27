using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Triangulo
    {
        /*
        7. Crie uma classe chamada “Triângulo” com atributos para armazenar os três lados do
        triângulo. Implemente métodos para verificar se é um triângulo válido e calcular sua área.
        */

        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public bool ValidaTriangulo()
        {
            if (Lado1 + Lado2 > Lado3 && Lado1 + Lado3 > Lado2 && Lado2 + Lado3 > Lado1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalcularArea()
        {
            try
            {
                if (ValidaTriangulo())
                {
                    double sPerim = (Lado1 + Lado2 + Lado3) / 2;
                    double area = Math.Sqrt(sPerim * (sPerim - Lado1) * (sPerim - Lado2) * (sPerim - Lado3));
                    return area;
                }
                else
                {
                    throw new Exception("ERRO! O triângulo não é valido.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            
        }



    }
}
