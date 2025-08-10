//5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .


int n1 = 0, n2 = 0, n3 = 0, n4 = 0;
Console.Write("Ingrese un numero: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese un SEGUNDO numero: ");
n2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese un TERCER numero: ");
n3 = int.Parse(Console.ReadLine());
Console.Write("Ingrese un CUARTO numero: ");
n4 = int.Parse(Console.ReadLine());
if (n1 > n2 && n2 > n3 && n3 > n4)
{
    Console.WriteLine("Los numeros estan ordenados de forma DECRECIENTE");
}else
{
    Console.WriteLine("NO estan ordenados de forma decreciente...");
}