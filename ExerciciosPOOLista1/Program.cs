﻿namespace ExerciciosPOOLista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Circulo c1 = new Circulo(20);
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(c1.CalcularPerimetro());*/

            /*ContaBancaria minhaConta = new ContaBancaria(230538, "Lucas Amaral", 28000);
            minhaConta.Depositar(14000);
            Console.WriteLine(minhaConta.Saldo);*/

            /*Aluno lucas = new Aluno("Lucas", 123, 10, 8);
            Console.WriteLine(lucas.CalcularMedia());
            lucas.VerificarSituacao();*/

            /*Funcionario ze = new Funcionario("Zé", 3320, "Vendedor");
            Console.WriteLine(ze.CalcularSalarioLiq());*/

            /*Triangulo t = new Triangulo(9, 10, 11);

            Console.WriteLine(t.CalcularArea());*/

            /*Carro carro = new Carro("Fiat", "Celta");
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.Acelerar();
            carro.ExibirVelocidade();
            carro.Frear();
            carro.Frear();
            carro.ExibirVelocidade();*/

            /*Paciente p1 = new Paciente("Godofredo", 20);
            p1.AdicionarConsulta("Avaliação do cotovelo, realizada no dia 22/01/2002");
            p1.AdicionarConsulta("Avaliação do baço, realizada no dia 14/12/2002");
            p1.ExibirConsultas();*/

            /*Console.WriteLine(DateTime.Now.ToString("yyyy"));*/

            Pessoa lucas = new Pessoa("Lucas", 22, "Aprendiz");
            lucas.CalculaIdadeBissextos();
        }
    }
}
