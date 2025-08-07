// 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.


int n1 = 0;
Console.WriteLine("Ingrese un numero para evaluar si es mayor o menor a 10...");
n1 = int.Parse(Console.ReadLine());
if (n1 > 10)
{
    Console.WriteLine("El numero que ingreso es mayor a 10");
}else
{
    Console.WriteLine("El numero no es mayor");
}