using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Caixa---\n");
            int altura, largura, profundidade, calculo;
            Console.WriteLine("Imagine uma caixa e me diga a altura dela");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora me diga qual é a largura da sua caixa imaginaria?");
            largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a profundidade dessa caixa?");
            profundidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculando os numeros da sua caixa imaginaria.....");
            Console.ReadLine();
            calculo = altura * largura * profundidade;

            Console.Clear();

            Console.WriteLine("\t\t----Resultado----\n");
            Console.WriteLine($"o resultado da sua esquizofrênia é: {calculo}");

        }
    }
}
