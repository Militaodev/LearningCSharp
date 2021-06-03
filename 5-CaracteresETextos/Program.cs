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
            // character = 1 caracter e tenque ser com ' e ele tambem aceita espaços como caractere
            char primeiraCaractere = 'a';
            Console.WriteLine(primeiraCaractere);
            // é pra printar A
            primeiraCaractere = (char)65;
            Console.WriteLine(primeiraCaractere);

            // é pra printar B
            primeiraCaractere = (char)(primeiraCaractere + 1);
            //ASCII table

            string titulo = "Militao";
            Console.WriteLine(titulo);

            // @ serve para aceitar a quebrar linhas 
            string cursosProgamacao = @"- Java -
            - Python 
             - Js";
            Console.WriteLine(cursosProgamacao);


            Console.ReadLine();
        }
    }
}
