using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, temp;

            Console.WriteLine("\t\t Trabalhando com Array!!!");

            try
            {
                // Solicita a informação de quantos numeros vai ser usado.
                Console.WriteLine("Informe quantos números você quer usar:");
                numero = Convert.ToInt32(Console.ReadLine());
                int[] numeros = new int[numero];

                //Recebe os números do usuário através de um laço for.
                for (int i = 0; i < numero; i++)
                {
                    Console.Write($"Informe o nº{i} valor:");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                //Realiza a ordenação dos números.
                for (int i = 0; i < numero; i++)
                {
                    for (int j = 0; j < numero - 1; j++)
                    {
                        if (numeros[j] > numeros[j + 1])
                        {
                            temp = numeros[j];
                            numeros[j] = numeros[j + 1];
                            numeros[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Ordenado em Ordem Ascendente:");
                //Imprime os números ordenados.
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
