using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDosDigitos
{
    public class Digitos
    {
        public void Calcular(int numero, int tamanho)
        {
            int a;
            int soma = 0;

            for (int i = 1; i <= tamanho; i++)
            {
                a = numero % 10;
                numero = numero / 10;
                Console.Write(a);
                if (tamanho > i)
                {
                    Console.Write(" + ");
                }
                soma += a;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"A soma dos digitos individuais deste número é =>{soma}");
        }
    }
}
