using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaSeONumeroEPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, numEscolhido;

            Console.WriteLine("\t\t Verificando se os números são primos.");

            try
            {
                //Recebendo o número digitado pelo usuário.
                Console.Write("Informe o primeiro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Chamando o método para ver qual número é o maior.
                numEscolhido = VerificaNumero.NumeroMaior(num1, num2);
                Console.WriteLine($"\nO número maior é: {numEscolhido}\n");

                //Chamando o método para ver se os números são primos.
                VerificaNumero.NumeroPrimo(numEscolhido);

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
