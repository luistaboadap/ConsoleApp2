// Verifica si un número ingresado por el usuario es primo o no.
Console.WriteLine("determinar si un numero es primo");
int n = 0;
int c = 0;
Console.WriteLine("ingrese un numero: ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    if (n % i == 0)
    {
        c++;
    }
}
if (c != 2)
{
    Console.WriteLine("no es primo");
}
else
{
    Console.WriteLine("es primo")
}

