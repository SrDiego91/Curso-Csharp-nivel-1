//3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.


float edades = 0, acumulador = 0, resultado = 0;
for (int x = 0; x < 20; x++)
{
    Console.Write("Ingrese una edad: ");
    edades = float.Parse(Console.ReadLine());
    if (edades > 18)
    {
        acumulador += edades;
    }
}
resultado = acumulador / 20;
Console.WriteLine("El promedio es: " + resultado + acumulador);