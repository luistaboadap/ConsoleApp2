// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Crea una lista de los cuadrados de los primeros 10 números naturales
Console.WriteLine("Ingrese numero: ");
int num1 = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= num1; i++)
{
    suma = suma + (i * i);
    Console.Write($"Cuadrado de {i} es: {(i * i)} \n");
}
Console.Write($"la suma de los {num1} primeros numeros es: {suma}");
Console.ReadKey();
