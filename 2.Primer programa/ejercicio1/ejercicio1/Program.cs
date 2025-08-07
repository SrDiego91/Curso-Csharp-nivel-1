// 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
int n1 = 0, n2 = 0, resultado = 0;
Console.WriteLine("ingrese 2 numeros para sumarlos...");
Console.WriteLine("ingrese el primero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo");
n2 = int.Parse(Console.ReadLine());
resultado = n1 + n2;
Console.WriteLine("El resultado es: " + resultado);
