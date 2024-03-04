using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class ContaBancaria
    {
        /*
        2. Implemente uma classe chamada “ContaBancária” que possua atributos para armazenar o
        número da conta, nome do titular e saldo. Adicione métodos para realizar depósitos e
        saques.
        */

        public int NumeroDaConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria (int numeroDaConta, string nomeTitular, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
