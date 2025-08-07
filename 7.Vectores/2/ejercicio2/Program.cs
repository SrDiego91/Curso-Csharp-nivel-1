using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            double n = 0, promedio = 0, mayor = 0;
            double[] numeros = new double[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite un numero: ");
                n = double.Parse(Console.ReadLine());
                numeros[x] = n;
                promedio += n;
                if (n > mayor)
                {
                    mayor = n;
                }
            }
            promedio = promedio / 10;
            if (mayor > promedio)
            {
                Console.WriteLine("El promedio es: " + promedio + " y el numero mayor al promedio es: " + mayor);
            }else
            {
                Console.WriteLine("El promedio es: " + promedio + " \nNo hay numero mayor al promedio...");
            }
        }
    }
}
