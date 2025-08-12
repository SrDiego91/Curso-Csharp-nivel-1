using System;

namespace ejercicio1
{
    class Program
    {
       
        static int haceAlgo2(ref int numero, ref int numero2)
        {
            int res;
            numero = numero * 2;
            numero2 = numero2 * 3;

            res = numero * numero2;

            return res;
        }
        static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese un numero: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("El Resultado es: " + haceAlgo2(ref a, ref b));
        Console.WriteLine("El Resultado es: " + haceAlgo2(ref a, ref b));
        Console.WriteLine("El Resultado es: " + haceAlgo2(ref a, ref a));
    }
    
    }
}
