// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Genera los primeros 10 números de la serie Fibonacci 
int a = 0; int b = 1; int c = 1;
Console.WriteLine("ingrese numero: ");
int N = int.Parse(Console.ReadLine());

while (c <= N)
{
    if (c % 2 == 1)
    {
        Console.Write(a + ",");
        a = a + b;
    }
    else
    {
        Console.Write(a + ",");
        a = a + b;
    }
    c = c + 1;
}
Console.ReadKey();
