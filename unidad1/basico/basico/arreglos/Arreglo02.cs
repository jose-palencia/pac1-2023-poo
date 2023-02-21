using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo02
    {
        public Arreglo02()
        {
            Random random = new Random();
            bool continuar;
            do
            {
                Console.WriteLine("Ingrese la cantidad de numeros a generar");
                int limite = int.Parse(Console.ReadLine());
                int[] numeros = new int[limite];

                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros[" + i + "] = " + numeros[i]);
                }

                Console.WriteLine("Desea continuar? (s/n)");
                continuar = Console.ReadLine().ToLower() == "s";

            } while (continuar);

            
        }
    }
}
