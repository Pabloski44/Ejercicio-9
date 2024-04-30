namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Bienvenido al Proyecto-ETS");
            Console.WriteLine("----MENU CALCULADORA----");
            Console.WriteLine("¿Que operación deseas realizar?");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - División");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op) 
            {
                case 0:
                    Console.WriteLine("Hasta la próxima");
                    break;
                case 1:
                    Console.WriteLine("Indica el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indica el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La suma da un total de " + Funciones.Sumar(a,b));
                    break;
                case 2:
                    Console.WriteLine("Indica el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indica el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La resta da un total de " + Funciones.resta(a, b));
                    break;
                case 3:
                    Console.WriteLine("Indica el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indica el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La multiplicación da un total de " + Funciones.Multiplicar(a, b));
                    break;
                case 4:
                    Console.WriteLine("Indica el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indica el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La multiplicación da un total de " + Funciones.division(a, b));
                    break;
            }
            Console.ReadKey();
        }
    }
}
