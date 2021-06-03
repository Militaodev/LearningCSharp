using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");
            int idade = 16;
            int quantidadeDePessoas = 2;
            if (idade >= 18)
            {
                Console.WriteLine("João possui 18 anos de idade");
            }else
            {
                if(quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João esta acompanhado pode entrar");
                }
                else
                {
                Console.WriteLine("João não possui 18 anos e não pode entrar");
                }
            }
            Console.ReadLine();
        }
    }
}
