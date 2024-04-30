using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Funciones
    {
        public void resta(int a, int b)
        {
            int calculo;
            calculo =  a - b;
            Console.WriteLine("La suma de {0} y {1} es : {2}", a, b, calculo);
        }
    }
}
