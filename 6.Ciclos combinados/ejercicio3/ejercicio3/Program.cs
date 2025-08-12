//3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.


int n = 0, contador_numeros = 0, temp = 0, grupo = 1;
Console.Write("Ingrese un numero: ");
n = int.Parse(Console.ReadLine());
while (n != 0)
{
    while (n != -1)
    {
        contador_numeros++;
        Console.Write("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("La lista " + grupo + " tiene " + contador_numeros + " numeros");
    grupo++;
    Console.Write("Ingrese un numero: ");
    n = int.Parse(Console.ReadLine());
    contador_numeros = 0;
}
