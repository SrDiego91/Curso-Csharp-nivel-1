// 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.


int n1 = 0, n2 = 0, n3 = 0, n4 = 0, menor = 0;
Console.WriteLine("Ingrese 4 numeros para determinar cual es menor de ellos...");
Console.WriteLine("Ingrese el PRIMER numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el SEGUNDO numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el TERCER numero");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el CUARTO numero");
n4 = int.Parse(Console.ReadLine());
if (n1 < n2 && n1 < n3 && n1 < n4)
{
    menor = n1;
    Console.WriteLine("El menor es: " + menor);
}
else if (n2 < n1 && n2 < n3 && n2 < n4)
{
    menor = n2;
    Console.WriteLine("El menor es: " + menor);
}
else if (n3 < n1 && n3 < n2 && n3 < n4)
{
    menor = n3;
    Console.WriteLine("El menor es: " + menor);
}
else
{
    menor = n4;
    Console.WriteLine("El menor es: " + menor);
}
