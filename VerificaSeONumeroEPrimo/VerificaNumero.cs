using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaSeONumeroEPrimo
{
    public class VerificaNumero
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }


        public static int NumeroMaior(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static void NumeroPrimo(int num)
        {
            int primo = 2;
            while (primo < num)
            {
                if (num % primo == 0)
                {
                    Console.WriteLine("\nEsté número e um número composto.");
                    break;
                }
                primo++;
            }
            if (primo == num)
            {
                Console.WriteLine("\nEsté número é um número primo.");
            }
            if (num == 0 || num == 1)
            {
                Console.WriteLine("\nEsté número não é composto e nem primo.");
            }
        }
    }
}
