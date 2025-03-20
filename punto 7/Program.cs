
using System.Diagnostics.Tracing;
int dia;
do
{
   
    Console.WriteLine("ingrese un numero para indicar un dia de la semana o 0 para salir");
    dia = int.Parse(Console.ReadLine());
    Console.Clear();
    if (dia== 1 )
    {
        Console.WriteLine("lunes");
    }
    if (dia == 2)
    {
        Console.WriteLine("martes");
    }
    if (dia == 3)
    {
        Console.WriteLine("miercoles");
    }
    if (dia == 4)
    {
        Console.WriteLine("jueves");
    }
    if (dia == 5)
    {
        Console.WriteLine("viernes");
    }
    if (dia == 6)
    {
        Console.WriteLine("sabado");
    }
    if (dia == 7)
    {
        Console.WriteLine("domingo");
    }
} while (dia !=0); 
Console.ReadKey();