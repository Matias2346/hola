

int a, b;
Console.WriteLine("ingrese el numero de inicio");
a = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el numero de final");
b = int.Parse(Console.ReadLine());
Console.Clear();

for (int i = a; i <= b ; i++)
{
    Console.WriteLine(i);

}
Console.ReadKey();