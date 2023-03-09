using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Aprendendo Matemática básica---");
            double mais, menos, vezes, dividir, num1, num2;
            Console.WriteLine("Digite um numero real");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero real");
            num2 =double.Parse(Console.ReadLine());
            Console.WriteLine("Preparando os calculos");
            Console.ReadLine();
            Console.WriteLine("Pronto!!! Aperte continuar para ver os resultados");
            Console.ReadLine();
            mais = num1 + num2;
            menos = num1 - num2;
            vezes = num1 * num2;
            dividir = num1 / num2;

            Console.Clear();
            Console.WriteLine("\t\t---O resultado foi:---");
            Console.WriteLine(" O resultado da conta de adição foi: {0}\n O resultado da conta de subtração foi: {1}\n O resultado da conta de multiplicação foi: {2}\n O resultado da conta de divisão foi: {3}",mais,menos,vezes,dividir);
        }
    }
}
