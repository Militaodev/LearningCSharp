using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9");
            int idade = 16;
            int quantidadeDePessoas = 2;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }
            else
            {
                mensagemAdicional = "Joao não esta acompanhado";
            }

            if (idade >= 18 || acompanhado == true)// ou eu posso colocar só o acompanhado
            {
                Console.WriteLine("Entrada autorizada");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Entrada negada");
            }
            Console.ReadLine();
        }
    }
}
