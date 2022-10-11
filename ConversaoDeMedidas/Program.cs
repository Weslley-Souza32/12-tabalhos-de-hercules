using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            char opcao;
            double centimetro, litro, kilometro;


            Console.WriteLine("Informe um valor inteiro para converter: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. P->Polegadas Para Centímetros.\n2. G->Galão Para Litro.\n3. M->Milhas Para Kilometro.");
            opcao = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (opcao)
            {
                case 'P':
                    centimetro = valor / 0.3937; //1 cm é igual a o.3937 polegadas.
                    Console.WriteLine($"\n{valor} polegadas são {centimetro.ToString("f2", CultureInfo.InvariantCulture)} centimetros(cm)");
                    break;
                case 'G':
                    litro = valor * 3.78; //1 galão é igual a 3.78 litros.
                    Console.WriteLine($"\n{valor} Galões são {litro.ToString("f2",CultureInfo.InvariantCulture)} litros(l) ");
                    break;
                case 'M':
                    kilometro = valor * 1.60; //1 milha é igual a 1.60 kilometro.
                    Console.WriteLine($"\n{valor} Milhas são {kilometro.ToString("f2",CultureInfo.InvariantCulture)} kilometros(Km) ");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Informe uma das opções oferecidas: P, G ou M");
                    break;
            }
            Console.ReadLine();


        }
    }
}
