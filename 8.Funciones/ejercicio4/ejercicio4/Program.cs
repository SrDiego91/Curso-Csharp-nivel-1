using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            //Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.
            int n1 = 0, resultado = 0;
            n1 = Datos();
            PositivoNegativoCero(n1, ref resultado);
            Console.WriteLine("el resultado es: " + resultado);
        }
        static int Datos()
        {
            int d = 0;
            Console.WriteLine("ingrese un numero: ");
            d = int.Parse(Console.ReadLine());
            return d;  
        }
        static void PositivoNegativoCero(int n1p, ref int resultadop)
        {
            
            if (n1p > 0)
            {
                resultadop = 1;
            }
            if (n1p < 0)
            {
                resultadop = -1;
            }if (n1p == 0)
            {
                resultadop = 0;
            }
        }
    }
}
