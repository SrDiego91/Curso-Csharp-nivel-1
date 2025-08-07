// 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


double importe_venta = 0, importe_final = 0, descuento1 = 0.90, descuento2 = 0.82;
Console.WriteLine("Ingrese el importe para ver si le corresponde un descuento...");
importe_venta = double.Parse(Console.ReadLine());
if (importe_venta >= 1000 && importe_venta < 5000)
{
    importe_final = importe_venta * descuento1;
    Console.WriteLine("El importe final con descuento del 10% es: " + importe_final);
}else if (importe_venta >= 5000)
{
    importe_final = importe_venta * descuento2;
    Console.WriteLine("El importe final con descuento del 18% es: " + importe_final);
}else
{
    Console.WriteLine("No hay descuento...");
}