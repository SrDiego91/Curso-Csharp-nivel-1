using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.(listo)
            //b) Los números de artículos que no registraron ventas.(listo)
            //c) Cuantas unidades se vendieron del número de artículo 10.(listo)
            int n = 0, articulo_mas_vendido = 0, bandera_1 = 0, indice = 0, articulo_10 = 0, cantidad = 0;
            int[] articulos = new int[15];
            int[] no_registraron_ventas = new int[15];
            for (int x = 0; x < 15; x++)
            {
                Console.WriteLine("Cuantas unidades se vendieron del articulo " + (x + 1) + " \"Presione 0 para terminar de cargar...\"");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    articulos[x] += n;
                    n = int.Parse(Console.ReadLine());

                }
                if (bandera_1 == 0)
                {
                    cantidad = articulos[x];
                    articulo_mas_vendido = x + 1;
                    bandera_1++;
                }
                if (articulos[x] > cantidad)
                {
                    cantidad = articulos[x];
                    articulo_mas_vendido = x + 1;
                }
                if (articulos[x] == 0)
                {
                    no_registraron_ventas[indice] = x;
                    indice++;
                }
                if (x == 9)
                {
                    articulo_10 = articulos[x];
                }

            }
            Console.WriteLine("El articulo que mas se vendio fue: " + articulo_mas_vendido);
            indice = 0;
            while (no_registraron_ventas[indice] > 0 && no_registraron_ventas[indice] <= 15)
            {
                Console.WriteLine("Los articulos que no generaron ventas son: " + (no_registraron_ventas[indice] + 1));
                indice++;
            }
            Console.WriteLine("Del articulo 10 se vendieron: " + articulo_10);
        }
    }
}
