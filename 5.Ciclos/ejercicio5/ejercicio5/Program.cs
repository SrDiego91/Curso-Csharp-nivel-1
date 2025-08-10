//5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.


int numeros = 0, maximo_par = 0, minimo_impar = 0, temp = 0, bandera_par = 0, bandera_impar = 0;
for (int x = 0; x < 20; x++)
{
    Console.Write("Ingrese un numero: ");
    numeros = int.Parse(Console.ReadLine());
    temp = numeros % 2;
    if (temp == 0)
    {
        if (bandera_par == 0)
        {
            maximo_par = numeros;
            bandera_par++;
        }
        if (numeros > maximo_par)
        {
            maximo_par = numeros;
        }
    }
    else if (temp != 0)
    {
        if (bandera_impar == 0)
        {
            minimo_impar = numeros;
            bandera_impar++;
        }
        if (numeros < minimo_impar)
        {
            minimo_impar = numeros;
        }
    }
}
Console.WriteLine("El maximo PAR es: " + maximo_par + " Y el minimo IMPAR es: " + minimo_impar);