using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Idade média de alunos---\n");
            int kid1, kid2, kid3, kid4, kid5, conta;
            Console.WriteLine("Digite a idade de uma kid");
            kid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade de outra kid");
            kid2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da terceira kid");
            kid3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da quarta kid");
            kid4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da última kid");
            kid5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculando a média de todas as kids....");
            Console.ReadLine();
            conta = (kid1 + kid2 + kid3 + kid4 + kid5) /5;

            Console.Clear();

            Console.WriteLine("\t\t----Resultado da Média----\n");
            Console.WriteLine($"a media é {conta}");
        }
    }
}
