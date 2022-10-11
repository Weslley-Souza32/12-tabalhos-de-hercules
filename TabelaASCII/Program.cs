using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tConstruindo a Tabela ASCII\n\t   Utilizando laço While.\n");

            char ch;
            int i = 0;

            do
            {
                Console.Write(i);
                Console.Write(" ");
                ch = (char)i;
                Console.WriteLine(ch);
                i++;
            } while (i <= 255);

            Console.ReadLine();
        }
    }
}
