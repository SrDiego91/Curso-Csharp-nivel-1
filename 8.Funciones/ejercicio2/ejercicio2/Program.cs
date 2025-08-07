using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n = 0, contador_de_pares = 0, contador = 0;
            for (int x = 0; x < 20; x++)
            {
                PideDatos(ref n);
                contador = Par(n);
                if (contador == 0)
            {
                contador_de_pares++;
            }
            }
            Console.WriteLine("La cantidad de pares son: " + contador_de_pares);
        }
        static int Par(int a)
        {
            int r = 0;
            r = a % 2;
            return r;
        }
        static void PideDatos(ref int resultado)
        {
            Console.WriteLine("ingrese 20 numeros: ");
            resultado = int.Parse(Console.ReadLine());
            
        }
    }
}
