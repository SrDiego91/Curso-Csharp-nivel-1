//4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.


int n1 = 0, n2 = 0, n3 = 0;
Console.Write("Ingrese un numero: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese un segundo numero: ");
n2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese un tercer numero: ");
n3 = int.Parse(Console.ReadLine());
if ((n1 + n2) > (n2 * n3))
{
    Console.WriteLine("La SUMA es mayor");
}else
{
    Console.WriteLine("El PRODUCTO es mayor");
}