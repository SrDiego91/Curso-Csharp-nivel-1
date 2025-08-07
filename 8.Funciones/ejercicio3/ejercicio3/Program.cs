using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int n = 0, num = 0, contador = 0, acumulador = 0, promedio = 0;
            n = Datos(n);
            while (n != 0)
            {
                num = Primo(n);
                if (num == 1)
                {
                    acumulador += n;
                    contador++;
                }
                n = Datos(n);
                


            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de primos es: " + promedio);


        }
        static int Datos(int dato)
        {
            Console.WriteLine("Digite un numero: ");
            dato = int.Parse(Console.ReadLine());
            return dato;
        }
        static int Primo(int s)
        {
            int divi = 0, contador = 0;
            for (int x = 1; x <= s; x++)
            {
                divi = s % x;
                if (divi == 0)
                {
                    contador++;
                }
                
            }
            
            if (contador == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
            

        }
        
    }
}
