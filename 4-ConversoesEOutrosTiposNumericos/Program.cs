using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4- Conversões e outros tipos numericos");
            
            // numeros quebrados
            double salario;
            salario = 1200.50;
            
            // numeros inteiros
            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine("meu salario arredondade é igual a " + salarioInteiro);
            
            // numeros  maiores que o inteiro
            long idade;
            idade = 14;

            Console.WriteLine("minha idade é igual a "+idade);

            // quantidade muito pequena que vai até o numero 32767
            short quantidadeDeProdutos;
            quantidadeDeProdutos = 32767;
            Console.WriteLine("a sua quantidade de produtos é igual a "+quantidadeDeProdutos);


            // tem menor precisão que o doble e temos que colocar o f no final para que o progama n acha que é um erro de digitação
            float altura;
            altura = 1.5f;
            Console.WriteLine("a sua altura é igual a "+altura);

            //tambem posso fazer assim 
            float perimetro = 1.7f;
            Console.WriteLine("o perimetro é igual a " + perimetro);


            Console.WriteLine("Para cancelar a execução aperte a tecle ENTER");
            
            // para apertar enter e cancelar a execução
            Console.ReadLine();
        }
    }
}
