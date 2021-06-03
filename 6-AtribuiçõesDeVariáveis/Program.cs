using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçõesDeVariáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6 iniciando");

            int idade = 32;
            int idadeGustavo = idade;
            // o c# n faz o recalculamento do valor idadeGustavo 

            idade = 20;

            Console.WriteLine(idadeGustavo);
            Console.WriteLine(idade);




            Console.ReadLine();
        }
    }
}
