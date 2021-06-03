using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");
            int idade = 16;
            int quantidadeDePessoas = 2;
            //temos as variaveis de valor booleano que se cahma dentro do csharp 
            bool acompanhado = true;

            // algumas linguagens usam o or mas o cSHARP  usa as duas barras na vertical || e para ele ter as duas condiçoes ele usa && dosi es comerciais 
            if (idade >= 18 || acompanhado == true )// ou eu posso colocar só o acompanhado
            {
                Console.WriteLine("Entrada autorizada");
            }
            else
            {
                Console.WriteLine("Entrada negada");
            }
            Console.ReadLine();
        }
    }
}
