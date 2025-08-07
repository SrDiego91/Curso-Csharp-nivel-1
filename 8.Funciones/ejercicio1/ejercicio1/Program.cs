using System;
using System.Runtime.CompilerServices;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            PideDatos(ref n1, ref n2);
            resultado = Producto(n1, n2);
            Console.WriteLine("El monto total a pagar es de: " + resultado);
            
        }

        static int Producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }

        static void PideDatos(ref int pa, ref int c)
        {
            Console.WriteLine("Ingrese el precio del articulo: ");
            pa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de produstos: ");
            c = int.Parse(Console.ReadLine());
            
        }
    }
}
