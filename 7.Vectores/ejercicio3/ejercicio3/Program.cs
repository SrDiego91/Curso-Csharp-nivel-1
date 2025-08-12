using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            //Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
            char[] texto = new char[100];
            char letra, caracter_1, caracter_2;
            int indice_carga_de_nombre = 0;
            Console.WriteLine("Ingrese el texto letra por letra, (para terminar presione punto)");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice_carga_de_nombre < 100)
            {
                texto[indice_carga_de_nombre] = letra;
                indice_carga_de_nombre++;
                letra = char.Parse(Console.ReadLine());
            }
            texto[indice_carga_de_nombre] = '\0';
            Console.WriteLine("ingrese el primer caracter: ");
            caracter_1 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo caracter: ");
            caracter_2 = char.Parse(Console.ReadLine());
            indice_carga_de_nombre = 0;
            while (texto[indice_carga_de_nombre] != '\0')
            {
                if (caracter_1 == texto[indice_carga_de_nombre])
                {
                    texto[indice_carga_de_nombre] = caracter_2;
                }

                indice_carga_de_nombre++;
            }
            indice_carga_de_nombre = 0;
            while (texto[indice_carga_de_nombre] != '\0')
            {
                Console.Write(texto[indice_carga_de_nombre]);
                indice_carga_de_nombre++;
            }

        }
    }
}
