using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.tipo_datos
{
    internal class Tipos02
    {
        public Tipos02()
        {
            // String => cadena de caracteres
            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine();

            // Int => valores enteros o numericos
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su genero");
            bool genero = bool.Parse(Console.ReadLine());

            Console.WriteLine("El nombre ingresado es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su genero es: " + genero);
             
        }
    }
}
