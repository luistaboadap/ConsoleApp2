

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 12) Verifica si una palabra ingresada por el usuario es un palíndromo
Console.WriteLine("Ingrese una palabra:");
string palabra = Console.ReadLine();

// Convertir la palabra a minúsculas para evitar problemas de mayúsculas y minúsculas
palabra = palabra.ToLower();

bool esPalindromo = true;

// Verificar si la palabra es un palíndromo
for (int i = 0; i < palabra.Length / 2; i++)
{
    if (palabra[i] != palabra[palabra.Length - i - 1])
    {
        esPalindromo = false;
        break;
    }
}

if (esPalindromo)
{
    Console.WriteLine("La palabra ingresada es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra ingresada no es un palíndromo.");
}
