

int n1=0, n2=0;
Console.WriteLine("ingrese el numero de inicio");
    n1=int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el numero de fin");
    n2 = int.Parse(Console.ReadLine());
Console.Clear();
    
while (n1<=n2)
{
    Console.WriteLine(n1);
    n1++;
}
Console.ReadKey();