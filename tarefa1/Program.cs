using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Dados do usuário---\n");
            string nome, endereco, telefone;
            Console.Write("Digite seu nome:");
            nome=Console.ReadLine();
            Console.Write("Digite seu endereço:");
            endereco=Console.ReadLine();
            Console.Write("Digite seu telefone:");
            telefone=Console.ReadLine ();
            Console.Clear();
            Console.WriteLine("\t\t---Dados do usuário---\n");
            Console.WriteLine("Nome: {0}\nEndereço: {1}\nTelefone: {2}", nome, endereco, telefone);
        }
    }
}
