using System;

namespace exercicio_logica_programacao6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Descobrir o MDC(máximo divisor comum):

            //Faça um programa para calcular o MDC(máximo divisor comum) entre dois números informados pelo usuário.

            //Aconselho a utilizar o método de divisões sucessivas, pois você verá que a forma como costumamos resolver 
            //problemas matemáticos na mão nem sempre é o melhor caminho quando estamos codificando.Aconselho também a 
            //pesquisar no Google sobre MDC.

            Console.WriteLine("Informe o primeiro valor: ");

            int valor1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");

            int valor2 = Convert.ToInt32(Console.ReadLine());

            int dividendo;
            int divisor;
            int resto;

            if (valor1 > valor2)
            {
                dividendo = valor1;
                divisor = valor2;
            }
            else
            {
                dividendo = valor2;
                divisor = valor1;
            }

            while (dividendo % divisor != 0)
            {
                resto = dividendo % divisor;
                dividendo = divisor;
                divisor = resto;
            }

            Console.WriteLine($"MDC = {divisor}");
        }
    }
}
