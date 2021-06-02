using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5-Caracteres e textos executando . . .");
            // character = 1 caracter e tenque ser com '
            char primeiraCaractere = 'a';
            Console.WriteLine(primeiraCaractere);
            // é pra printar A
            primeiraCaractere = (char)65;
            Console.WriteLine(primeiraCaractere);

            // é pra printar B
            primeiraCaractere = (char)(primeiraCaractere + 1);
            //ASCII table


            Console.ReadLine();
        }
    }
}
