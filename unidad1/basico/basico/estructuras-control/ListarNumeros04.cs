using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros04
    {
        public ListarNumeros04()
        {
            Console.WriteLine("Listar numeros hasta: ");
            int limite = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
