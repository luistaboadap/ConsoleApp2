
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 

Console.WriteLine("Ingrese la cantidad de numero:");
int cantidad = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[cantidad];

// Leer los números ingresados por el usuario
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Ingrese el número {0}:", i + 1);
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

// Ordenar la lista de números de menor a mayor
for (int i = 0; i < cantidad; i++)
{
    for (int j = i + 1; j < cantidad; j++)
    {
        if (numeros[i] > numeros[j])
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}

// Mostrar la lista ordenada
Console.WriteLine("Lista ordenada de menor a mayor:");
foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}
Console.WriteLine();
