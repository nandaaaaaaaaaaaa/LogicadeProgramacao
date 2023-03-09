using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Convertendo dias----");
            int dias, conta, semana, mes, ano;
            Console.WriteLine("Informe um numero de dias");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Convertendo os dias informado para semanas, mêses ou anos");
            Console.ReadLine();
            semana = dias / 7;
            mes = dias / 30;
            ano = dias / 365;

            Console.Clear();

            Console.WriteLine("\t\t----Resultado----");
            Console.WriteLine("O Resultado de dias convertidos para semana: {0}\n O Resultado de dias convertidos para mes: {1}\n O resultado de dias convertidos para ano: {2}", semana, mes, ano);
        }
    }
}
