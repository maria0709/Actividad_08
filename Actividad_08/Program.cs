using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_08
{
    class Program
    {
        //Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la palabra “fin”.
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("\r");

            if (frase.ToLower().Contains("fin")) 
             {
                Console.WriteLine("La frase que ingreso contiene la palabra 'fin'.");
             }
            else
            {
                Console.WriteLine("La frase que ingreso no contiene la palabra 'fin'.");
            }
            Console.ReadKey();
        }
    }
}
