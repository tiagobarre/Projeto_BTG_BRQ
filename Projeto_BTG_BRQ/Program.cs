using Domain;
using Entidades;
using System;

namespace Projeto_BTG_BRQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
           
        }

        static void Calc()
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("******************** SIMULADOR DE CAIXA ELETRÔNICO ***********************");
            Console.WriteLine("**************************************************************************");

            var calc = new CalculoSaque();
            Decimal VALOR = 0;

            Console.WriteLine("Por favor digite valores 30, 60, 80");

            // Ask the user to type the first number.
            Console.WriteLine("Digite o valor R$ que deseja sacar:");
            VALOR = Convert.ToDecimal(Console.ReadLine());
            var resp = calc.Saque(new Valores { ValorSolicitado = VALOR });

            if(resp == "12")
            {
                Console.WriteLine("Digite valores 30, 60, 80");

            }
            else
            {
                // Ask the user to choose an option.
                Console.WriteLine($"{resp}");

                // Wait for the user to respond before closing.

                Console.ReadKey();

            }

           

        }
    }
}
