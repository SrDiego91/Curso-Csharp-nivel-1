// 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.


double n1 = 0, n2 = 0, n3 = 0, resultado = 0;
Console.WriteLine("Ingrese la 3 notas para calcular el promedio...");
Console.WriteLine("Ingrese la primera nota");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la segunda nota");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la tercer nota");
n3 = double.Parse(Console.ReadLine());
resultado = (n1 + n2 + n3) / 3;
Console.WriteLine("El promedio es: " + resultado.ToString("0.0"));