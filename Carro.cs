using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOLista1
{
    public class Carro
    {
        /*
        8. Implemente uma classe chamada “Carro” com atributos para armazenar a marca, o modelo
        e a velocidade atual do carro. Adicione métodos para acelerar, frear e exibir a velocidade
        atual.
        */

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Velocidade { get; set; }

        public Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 5; 
        }

        public void Frear()
        {
            Velocidade -= 5;
        }

        public void ExibirVelocidade()
        {
            Console.WriteLine($"A velocidade atual é: {Velocidade}");
        }
    }
}
