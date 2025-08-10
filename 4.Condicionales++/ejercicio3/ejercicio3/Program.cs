//3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

//            i5 (1)	 i7 (2)	    i9 (3)
//8 RAM (1)	  USD 800	 USD 900	USD 1200
//16 RAM (2)  USD 900	 USD 1000	USD 1400
//32 RAM (3)  USD 1000	 USD 1400	USD 2000

//Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300.
//Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y 
//calcule y emita por pantalla el monto de la máquina seleccionada.


int opcion_procesador = 0, opcion_ram = 0, opcion_ssd = 0, precio_final = 0;
int i5_8ram = 800, i5_16ram = 900, i5_32ram = 1000;
int i7_8ram = 900, i7_16ram = 1000, i7_32ram = 1400;
int i9_8ram = 1200, i9_16ram = 1400, i9_32ram = 2000;
int ssd_adicional = 300;
Console.WriteLine("Opcion 1 (i5) // opcion 2 (i7) // opcion 3 (i9)");
Console.Write("Ingrese una opcion de PROCESADOR: ");
opcion_procesador = int.Parse(Console.ReadLine());
switch (opcion_procesador)
{
    //procesador i5
    case 1:
        Console.WriteLine("Elijio i5");
        Console.WriteLine("--------------------");
        Console.Write("Ingrese una opcion de RAM: ");
        Console.WriteLine("Opcion 1 (8 RAM) // opcion 2 (16 RAM) // opcion 3 (32 RAM)");
        opcion_ram = int.Parse(Console.ReadLine());
        switch (opcion_ram)
        {
            case 1:
                Console.WriteLine("Elijio 8 RAM");
                Console.WriteLine("--------------------");
                Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final += ssd_adicional + i5_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i5 con 8 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i5_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i5 con 8 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 2:
            Console.WriteLine("Elijio 16 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                    Console.WriteLine("--------------------");
                        precio_final = ssd_adicional + i5_16ram;
                        Console.WriteLine("Pidio un i5 con 16 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                    Console.WriteLine("--------------------");
                        precio_final = i5_16ram;
                        Console.WriteLine("Pidio un i5 con 16 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 3:
            Console.WriteLine("Elijio 32 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i5_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i5 con 32 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i5_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i5 con 32 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                        Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;

            default:
            Console.WriteLine("--------------------");
                Console.WriteLine("Esa opcion de RAM no existe");
                break;
        }
        break;
        //procesador i7
    case 2:
    Console.WriteLine("Elijio i7");
    Console.WriteLine("--------------------");
    Console.WriteLine("Opcion 1 (8 RAM) // opcion 2 (16 RAM) // opcion 3 (32 RAM)");
     Console.Write("Ingrese una opcion de RAM: ");
        opcion_ram = int.Parse(Console.ReadLine());
        switch (opcion_ram)
        {
            case 1:
                Console.WriteLine("Elijio 8 RAM");
                Console.WriteLine("--------------------");
                Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i7_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 8 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i7_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 8 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 2:
            Console.WriteLine("Elijio 16 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i7_16ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 16 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i7_16ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 16 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 3:
            Console.WriteLine("Elijio 32 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i7_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 32 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i7_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i7 con 32 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;

            default:
            Console.WriteLine("--------------------");
                Console.WriteLine("Esa opcion de RAM no existe");
                break;
        }
        break;
        // precesador i9
    case 3:
    Console.WriteLine("Elijio i9");
    Console.WriteLine("--------------------");
    Console.WriteLine("Opcion 1 (8 RAM) // opcion 2 (16 RAM) // opcion 3 (32 RAM)");
     Console.Write("Ingrese una opcion de RAM: ");
        opcion_ram = int.Parse(Console.ReadLine());
        switch (opcion_ram)
        {
            case 1:
                Console.WriteLine("Elijio 8 RAM");
                Console.WriteLine("--------------------");
                Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i9_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 8 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i9_8ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 8 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 2:
            Console.WriteLine("Elijio 16 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i9_16ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 16 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i9_16ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 16 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;
            case 3:
            Console.WriteLine("Elijio 32 RAM");
            Console.WriteLine("--------------------");
            Console.WriteLine("Quiere extender de 500GB a 1TB? (1 extender, 0 no extender)");
                Console.Write("Opcion: ");
                opcion_ssd = int.Parse(Console.ReadLine());
                switch (opcion_ssd)
                {
                    case 1:
                        precio_final = ssd_adicional + i9_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 32 de RAM y extension de disco, el total es: " + precio_final);
                        break;
                    case 0:
                        precio_final = i9_32ram;
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Pidio un i9 con 32 de RAM sin extension de disco, el total es: " + precio_final);
                        break;

                    default:
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Esa opcion de DISCO no existe");
                        break;
                }
                break;

            default:
            Console.WriteLine("--------------------");
                Console.WriteLine("Esa opcion de RAM no existe");
                break;
        }
        break;

    default:
    Console.WriteLine("--------------------");
        Console.WriteLine("Esa opcion de procesador no existe...");
        break;
}