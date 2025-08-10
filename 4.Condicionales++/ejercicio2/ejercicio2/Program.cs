// 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
//Si vende menos de 100 litros, no hay descuento.
//Si vende entre 101 y 300 litros, el descuento es del 10%.
//Si vende entre 301 y 500 litros, el descuento es del 15%.
//Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..


double importe_venta = 0, litros, importe_con_descuento = 0;
Console.Write("Ingrese el importe: ");
importe_venta = double.Parse(Console.ReadLine());
Console.Write("Ingrese los litros: ");
litros = double.Parse(Console.ReadLine());
if (litros >= 101 && litros <= 300)
{
    importe_con_descuento = importe_venta * 0.90;
    Console.WriteLine("El importe final es: " + importe_con_descuento);
}
else if (litros >= 301 && litros < 500)
{
    importe_con_descuento = importe_venta * 0.85;
    Console.WriteLine("El importe final es: " + importe_con_descuento);
}else if (litros >= 500)
{
    importe_con_descuento = importe_venta * 0.75;
    Console.WriteLine("El importe final es: " + importe_con_descuento);
}else
{
    Console.WriteLine("No hay descuento...");
}
