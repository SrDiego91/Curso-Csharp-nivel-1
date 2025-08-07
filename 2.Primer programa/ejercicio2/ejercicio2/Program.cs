//2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.


double n1 = 0, resultado = 0;
Console.WriteLine("Ingrese un numero para elevarlo al cubo...");
n1 = int.Parse(Console.ReadLine());
resultado = n1 * n1 * n1;
Console.WriteLine("El numero al cubo es: " + resultado);