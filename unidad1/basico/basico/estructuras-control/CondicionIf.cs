using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class CondicionIf
    {
        public CondicionIf()
        {
            Console.WriteLine("Condición");
            Console.WriteLine("-----------------------");

            Console.WriteLine("\nIngrese su edad");
            int edad = int.Parse(Console.ReadLine());

            /*
             * Operadores logicos
             * == Comparar
             * > Mayor que
             * < Menor que
             * >= Mayor o igual que
             * <= Menor o igual que
             * != Distinto
             * 
             * Compuertas logicos
             * && => AND ó Y
             * || => OR ú O
             * 
             */

            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            } else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            if (edad >= 16 && edad <= 18)
            {
                Console.WriteLine("Puede participar en la selección sub-18");
            } else 
            {
                Console.WriteLine("No puede participar en la selección sub-18");
            }
        }
    }
}
