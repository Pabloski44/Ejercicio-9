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
        public int resta(int a, int b)
        {
            int calculo;
            calculo =  a - b;
            return calculo;
        }
        public int division(int a, int b)
        {
            int calculo;
            calculo = a / b;
            return calculo;
        }
    }
}
