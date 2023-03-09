using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Consórcio---");
            int prestacoes, paga, valor, devendo, total;
            Console.WriteLine("Sobre o seu consórcio, qual é o numero total de prestações?");
            prestacoes = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de prestações pagas?");
            paga = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a o valor das prestações?");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculando o valor total do seu consórcio");
            Console.ReadLine();
            total = prestacoes*valor;
            devendo = paga - valor;

            Console.Clear();
            Console.WriteLine("\t\t----Valor Total----");
            Console.WriteLine("Resultado total: {0}\n Resultado devedor: {1}\n");

            

        }
    }
}
