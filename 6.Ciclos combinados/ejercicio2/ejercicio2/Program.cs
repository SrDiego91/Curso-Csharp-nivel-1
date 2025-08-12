//2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

//El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
//Informar cuántos grupos están formados por todos números ordenados de mayor a menor.


double porcentaje_de_numeros_impares = 0,temp2, grupos_de_menor_a_mayor = 0, grupo = 0, bandera_de_porcentaje_impares = 0, multiplicacion = 100;
for (int x = 0; x < 5; x++)
{
    double numero = 0, temp = 0, contador_impares = 0, contador_numeros = 0, bandera_mayor_a_menor = 0, mayor = 0, menor = 0;
    Console.WriteLine("Grupo de numeros: " + (x + 1));
    Console.Write("Ingrese un numero: ");
    numero = double.Parse(Console.ReadLine());
    while (numero != 0)
    {
        contador_numeros++;
        temp = numero % 2;
        if (temp != 0)
        {
            contador_impares++;
        }
        if (bandera_mayor_a_menor == 0)
        {
        mayor = numero;
        bandera_mayor_a_menor++;
        }
        if (contador_numeros == 2)
        {
        menor = numero;
        bandera_mayor_a_menor++;
        }
        Console.Write("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
    }
    temp2 = contador_impares * multiplicacion / contador_numeros;
    if (bandera_de_porcentaje_impares == 0)
    {
        porcentaje_de_numeros_impares = temp2;
        grupo = x + 1;
        bandera_de_porcentaje_impares++;
    }
    if (temp2 > porcentaje_de_numeros_impares)
    {
        porcentaje_de_numeros_impares = temp2;
        grupo = x + 1;
    }
    if (mayor > menor)
    {
        grupos_de_menor_a_mayor++;
    }
}
Console.WriteLine("El grupo con mas porcentaje de numeros impares es: " + grupo + " con un porcentaje del " + porcentaje_de_numeros_impares.ToString("0.0") + "%" + " \nY la cantidad de grupos que estan ordenados de mayor a menor son: " + grupos_de_menor_a_mayor);