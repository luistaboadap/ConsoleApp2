// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//14) Pide el radio de un círculo al usuario y calcula su área. 
double pi = Math.PI;
Console.WriteLine("Ingrese el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());

if (radio < 0)
{
    Console.WriteLine("El radio no puede ser negativo.");
}
else
{
    double area = pi * radio * radio;
    Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
}
