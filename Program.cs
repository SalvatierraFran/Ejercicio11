using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";

            int max = 0, min = 0, acum = 0;
            int flag = 0;
            double prom = 0;

            for(int i=0; i<10; i++)
            {
                Console.Write("Ingrese numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (Validacion.Validar(numero, -100, 100))
                {
                    if (numero > max)
                    {
                        max = numero;
                    }

                    if (flag==0 && min==0)
                    {
                        min = numero;
                        flag = 0;
                    }

                    if (numero < min)
                    {
                        min = numero;
                    }
                }

                acum = acum + numero;
                prom = (double)acum / 10;
            }

            Console.Write("El maximo es: " + max);
            Console.Write("\nEl minimo es: " + min);
            Console.Write("\nEl promedio es: {0:f2}", prom); 
            
            Console.ReadKey();
        }
    }
}
