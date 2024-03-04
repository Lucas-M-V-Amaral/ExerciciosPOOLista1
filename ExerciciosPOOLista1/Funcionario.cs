using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Funcionario
    {
        /*
        5. Crie uma classe chamada “Funcionário” com atributos para armazenar o nome, o salário e o
        cargo do funcionário. Implemente métodos para calcular o salário líquido, considerando
        descontos de impostos e benefícios. 
        */

        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo{ get; set; }

        public Funcionario(string nome, double salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public double CalcularSalarioLiq()
        {
            double inss;
            double valeTransporte;
            double salarioLiquido;

            if (Salario <= 1320)
            {
                inss = Salario * 0.075;
            }
            else if (Salario <= 2571.29) {
                inss = Salario * 0.09;
            }
            else if (Salario <= 3856.94)
            {
                inss = Salario * 0.12;
            }
            else
            {
                inss = Salario * 0.14;
            }

            valeTransporte = Salario * 0.06;

            salarioLiquido = Salario - inss - valeTransporte;
            return salarioLiquido;

        }
    }
}
