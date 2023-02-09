using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros02
    {
        public ListarNumeros02()
        {
            bool continuar = true;

            while (continuar) {
                Console.WriteLine("Listar numero hasta: ");

                int limite = int.Parse(Console.ReadLine());
                int i = 1;
                while (i <= limite)
                {
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Quiere seguir listando numeros (s/n)");
                String respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s") {
                    continuar = false;
                }
            }
        }
    }
}
