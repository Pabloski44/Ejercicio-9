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
        public static int resta(int a, int b)
        {
            int calculo;
            calculo =  a - b;
            return calculo;
        }
        public  static int division(int a, int b)
        {
            int calculo;
            calculo = a / b;
            return calculo;
        }
    }
}
