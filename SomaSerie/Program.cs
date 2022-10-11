using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaSerie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tSoma Serie!!!\n");
            int numero;
            double X, soma = 0;

            Console.WriteLine("Informe o intervalo de valores a exibir para série: " +
                              "\n1*^x+2*x^2+3*x^3+4*x^4+5*x^5+...+n*x^n");

            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"{i}*x^{i}");
                if (i < numero)
                {
                    Console.Write(" + ");
                }
                X = (double)i;
                soma += (i * Math.Pow(X, X));
            }

            Console.WriteLine($"\nA soma da série é: {soma}");
            Console.ReadKey();
        }
    }
}
