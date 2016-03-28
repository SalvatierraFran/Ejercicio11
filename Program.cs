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

            int max=0, min=0;
            int flag = 0;

            for(int i=0; i<4; i++)
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
            }

            Console.ReadKey();
        }
    }
}
