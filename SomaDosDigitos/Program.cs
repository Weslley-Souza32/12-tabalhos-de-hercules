using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDosDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Digitos digitos = new Digitos();

            string numero;
            int a;
            int tamanho;

            Console.WriteLine("\t\t A soma dos Digitos");

            try
            {
                Console.WriteLine("Informe um número inteiro:");
                numero = Console.ReadLine();
                tamanho = numero.Length;
                a = Convert.ToInt32(numero);

                digitos.Calcular(a, tamanho);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
