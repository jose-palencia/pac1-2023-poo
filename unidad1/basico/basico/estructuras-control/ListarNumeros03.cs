using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros03
    {
        public ListarNumeros03()
        {
            Console.WriteLine("Listar numero hasta: ");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= limite);
        }
    }
}
