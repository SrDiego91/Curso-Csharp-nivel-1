//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.


int n1 = 0, n2 = 0, n3 = 0, n4 = 0;
Console.WriteLine("Ingrese 4 numeros para determinar cuales son mayores a 100");
Console.WriteLine("Ingrese el PRIMER numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el SEGUNDO numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el TERCER numero");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el CUARTO numero");
n4 = int.Parse(Console.ReadLine());
if (n1 > 100)
{
    Console.WriteLine("El numero "+ n1 +" es mayor a 100");
}if (n2 > 100)
{
    Console.WriteLine("El numero "+ n2 +" es mayor a 100");
}if (n3 > 100)
{
    Console.WriteLine("El numero "+ n3 +" es mayor a 100");
}if (n4 > 100)
{
    Console.WriteLine("El numero "+ n4 +" es mayor a 100");
}else if(n1 < 100 && n2 < 100 && n3 < 100 && n4 < 100)
{
    Console.WriteLine("NINGUNO es mayor a 100");
}