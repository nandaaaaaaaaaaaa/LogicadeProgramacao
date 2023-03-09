using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Carros----");
            double litros, km, calculo;
            Console.WriteLine("Digite quantos litros de combustível tem o seu carro");
            litros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos km tem o seu carro");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculando os litros e os km do seu carro.....");
            Console.ReadLine();
            calculo = km / litros;

            Console.Clear();
            Console.WriteLine("\t\t---Resultado---");
            Console.WriteLine($" O resultado do cálculo é: {calculo}");

        }
    }
}
