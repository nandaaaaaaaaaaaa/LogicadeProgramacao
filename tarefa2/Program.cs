using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("\t\t---Multiplicação---\n");
            int num1, num2, resultado;
            Console.WriteLine("Digite um numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            Console.ReadLine();
            resultado = num1 * num2;
           
            Console.Clear();

            Console.WriteLine("\t\t---Resultado---\n");
            Console.WriteLine("1° número digitado: {0}\n 2° numero digitado: {1}\n múltiplicando os dois numeros o resultado é: {2}", num1, num2, resultado);
        }
    }
}
