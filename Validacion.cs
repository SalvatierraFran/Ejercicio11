using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int num, int num2, int num3)
        {
            if (num > num2 && num < num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
