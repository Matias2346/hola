int n = 0, par=0;
while (n<=50)
{
    if (n%2==0)
    {
        par = n;
        Console.WriteLine(par);
    }
    n++;
}
Console.ReadKey();