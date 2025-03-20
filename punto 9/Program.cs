int entero;
do
{

    Console.WriteLine("ingrese un numero entero");
    Console.WriteLine("ingrese 0 para salir");
    entero=int.Parse(Console.ReadLine());
    Console.Clear();
    if (entero != 0 )
    {
     if (entero %2== 0)
     {
        Console.WriteLine("es par");
     }

    }

} while (entero!=0);
Console.ReadKey();