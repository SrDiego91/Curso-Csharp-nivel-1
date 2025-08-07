// 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
//Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.


double sueldo = 15000, facturado = 0, sueldo_final = 0, comisión = 0.05;
Console.WriteLine("Ingrese el total facturado...");
facturado = double.Parse(Console.ReadLine());
sueldo_final = (facturado * comisión) + sueldo;
Console.WriteLine("El sueldo total es: " + sueldo_final);