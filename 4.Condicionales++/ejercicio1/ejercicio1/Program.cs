// 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
//La resta si el primero es mayor que el segundo.
//La suma si son iguales.
//El producto si el primero es menor.
//Se deberá emitir un cartel por pantalla con el resultado correspondiente.


int n1 = 0, n2 = 0, resultado = 0;
Console.WriteLine("Ingrese UN numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un SEGUNDO numero");
n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    resultado = n1 - n2;
    Console.WriteLine("La resta es: " + resultado);
}
else if (n1 == n2)
{
    resultado = n1 + n2;
    Console.WriteLine("La suma es: " + resultado);
}else if (n1 < n2)
{
    resultado = n1 * n2;
    Console.WriteLine("El producto es: " + resultado);
}
