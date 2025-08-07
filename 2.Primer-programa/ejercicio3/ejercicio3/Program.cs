//3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
//Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


double kilometros = 0, velocidad = 0, resultado = 0;
Console.WriteLine("Ingrese la distancia de la ciudad...");
kilometros = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la velocidad del vehiculo...");
velocidad = int.Parse(Console.ReadLine());
resultado = kilometros / velocidad;
Console.WriteLine("Llegara en: " + resultado.ToString("0.0") + " horas");