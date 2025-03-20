using System.Numerics;

int mes;

do
{
    Console.WriteLine("ingrese un numero para indicar el mes");
    mes = int.Parse(Console.ReadLine());
    if (mes==1)
    {
        Console.WriteLine("enero");
    }
    if (mes == 2)
    {
        Console.WriteLine("febrero");
    }
    if (mes == 3)
    {
        Console.WriteLine("marzo");
    }
    if (mes == 4)
    {
        Console.WriteLine("abril");
    }
    if (mes == 5)
    {
        Console.WriteLine("mayo");
    }
    if (mes == 6)
    {
        Console.WriteLine("junio");
    }
    if (mes == 7)
    {
        Console.WriteLine("julio");
    }
    if (mes == 8)
    {
        Console.WriteLine("agosto");
    }
    if (mes == 9)
    {
        Console.WriteLine("septiembre");
    }
    if (mes == 10)
    {
        Console.WriteLine("octubre");
    }
    if (mes == 11)
    {
        Console.WriteLine("noviembre");
    }
    if (mes == 12)
    {
        Console.WriteLine("diciembre");
    }

} while (mes >0&& mes<12);
Console.Clear();
Console.WriteLine("el valor ingresado es incorrecto");
Console.ReadKey ();