using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo01
    {
        public Arreglo01()
        {
            Random random = new Random();

            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = random.Next(1, 100);
                Console.WriteLine("numeros[" + i + "] = " + numeros[i]);
            }
        }
    }
}
