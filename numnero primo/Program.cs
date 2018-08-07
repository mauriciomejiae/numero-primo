using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del Autor: Mauricio Mejia Estevez
            //Fecha: 13 Noviembre 2016
            //Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
            //trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
            //6. Escriba un programa para calcular si un número es primo o no, recuerde que los 
            //números primos son aquellos que solo son divisibles por la unidad y por ellos mismos: ejemplo 5, 11, 17
            int num, divisor = 2;
            Console.WriteLine(" Dijite Un Número ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            while (divisor < num)
            {
                while (num % divisor != 0)
                    divisor = divisor + 1;
                if (num == divisor)
                {
                    Console.WriteLine(" el Número " + num + " Es un Número primo");
                }
                else
                {
                    Console.WriteLine(" el Número " + num + " No es Número primo ");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
