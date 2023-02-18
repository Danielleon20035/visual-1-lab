using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_1_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola mundo soy daniel");
            Console.ReadKey();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("soy Nombre");
            Console.ReadKey();

            Console.WriteLine("Ingrese su nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("soy " + Nombre);
            Console.ReadKey();

            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Ingrese su nombre");
            string sNombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            string sEdad = Console.ReadLine();

            Console.WriteLine("Ingrese su carrera");
            string sCarrera = Console.ReadLine();

            Console.WriteLine("Ingrese su Carné");
            string sCarné = Console.ReadLine();

            Console.WriteLine("Nombre " + sNombre);
            Console.WriteLine("Edad " + sEdad);
            Console.WriteLine("Carrera " + sCarrera);
            Console.WriteLine("Carné " + sCarné);
            Console.ReadKey();
        }
    }
}
