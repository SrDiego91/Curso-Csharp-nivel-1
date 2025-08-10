//4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
//Nota: un número es primo cuando es divisible únicamente por 1 y por sí mismo.


int n = 0, contador = 0, temp = 0;
Console.Write("Ingrese un numero: ");
n = int.Parse(Console.ReadLine());
for (int x = 1; x <= n; x++)
{
    temp = n % x;
    if (temp == 0)
    {
        contador++;
    }
}
if (contador == 2)
{
    Console.WriteLine("El numero ES primo...");
}else
{
    Console.WriteLine("El numero NO es primo..");
}