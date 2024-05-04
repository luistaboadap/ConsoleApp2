
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 
Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar del número es: {numero} ");

for (int i = 0; i <= 12; i++)
{
    Console.WriteLine($" {numero} x {i}  =  {(numero * i)}");
}
