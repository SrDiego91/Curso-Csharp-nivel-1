using System;
using System.Diagnostics.Contracts;

namespace ejercicioif
{
    class Program
    {


        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int numero = 0, numero_par = 0, numero_impar = 0, resultado = 0, maximo_par = 0, minimo_impar = 0, bandera_minimo_impar = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                resultado = numero % 2;
                if (resultado == 0)
                {
                    numero_par = numero;
                    if (maximo_par < numero_par)
                    {
                        maximo_par = numero_par;
                    }
                }
                if (resultado > 0)
                {
                    numero_impar = numero;
                    if (bandera_minimo_impar == 0)
                    {
                        bandera_minimo_impar++;
                        minimo_impar = numero_impar;
                    }
                    if (numero_impar < minimo_impar)
                    {
                        minimo_impar = numero_impar;
                    }



                }

            }
            Console.WriteLine("El maximo par es: " + maximo_par + " y el minimo impar es: " + minimo_impar);
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            // Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.
            //int n = 0, resultado = 0, cont = 0;
            //Console.WriteLine("Digite un numero: ");
            // n = int.Parse(Console.ReadLine());
            // for (int x = 1; x <= n; x++)
            // {
            //     resultado = n % x;
            //     if (resultado == 1)
            //     {
            //         cont++;
            //     }
            // }
            // if (cont == 2)
            // {
            //      Console.WriteLine("El numero que ingreso es primo");
            //  }else
            // {
            //     Console.WriteLine("El numero no es primo");
            // }


































            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            //int edades = 0, promedio = 0, contador = 0, suma = 0;

            //for (int x = 0; x < 20; x++)
            // {
            //  Console.WriteLine("Digite una edad: ");
            //  edades = int.Parse(Console.ReadLine());

            // if (edades > 18)
            // {
            //     contador++;
            //     suma += edades;


            //  }

            //  }
            //  promedio = suma / contador;
            //  Console.WriteLine("el promedio de personas mayores de edad es: " + promedio + " y la cantidad de personas mayores es: " + contador);








































            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.


            //int n = 0, mayor = 0;
            // Console.WriteLine("ingrese un numero: ");
            // n = int.Parse(Console.ReadLine());
            // for (int x = 0; x < 10; x++)
            // {
            //   if (n > mayor)
            //      {
            //         mayor = n;

            //      }
            //      Console.WriteLine("ingrese otro numero: ");
            //        n = int.Parse(Console.ReadLine());


            //  }
            //   Console.WriteLine("el mayor es: " + mayor);















            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}


        }
    }
}
