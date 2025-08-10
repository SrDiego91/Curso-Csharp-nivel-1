//2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.


int numero = 0, mayor = 0;
for (int x = 0; x < 10; x++)
{
    Console.Write("Ingrese un numero: ");
    numero = int.Parse(Console.ReadLine());
    if (mayor == 0)
    {
        mayor = numero;
    }
    if (numero > mayor)
    {
        mayor = numero;
    }
}
Console.WriteLine("El mayor es: " + mayor);