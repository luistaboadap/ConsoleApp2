
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Cuenta el número de vocales en una cadena de texto. 
Console.WriteLine("Escriva una palabra: ");
string palabra = Console.ReadLine().ToLower();
int contador = 0;

for (int i = 0; i < palabra.Length; i++)
{
    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'o' || palabra[i] == 'i' || palabra[i] == 'u')
    {
        contador++;
    }
}
Console.Write($"la cantidad de vocales en la palabra es de: " + contador);
Console.ReadLine();
