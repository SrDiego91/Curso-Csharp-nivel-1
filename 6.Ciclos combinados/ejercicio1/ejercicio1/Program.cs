//1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.


float contador_de_primos = 0;
for (int x = 0; x < 10; x++)
{
    float temp = 0, numeros = 0, contador = 0;
    Console.WriteLine("Ingrese un numero: ");
    numeros = float.Parse(Console.ReadLine());
    for (int y = 1; y <= numeros; y++)
    {
        temp = numeros % y;
        if (temp == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        contador_de_primos++;
    }
    
}
Console.WriteLine("La cantidad de primos son: " + contador_de_primos);