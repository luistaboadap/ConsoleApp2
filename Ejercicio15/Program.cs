//15) Toma un número entero y calcula la suma de sus dígitos.
Console.WriteLine("Ingrese un número entero:");
int numero = Convert.ToInt32(Console.ReadLine());

int sumaDigitos = 0;
int numeroActual = numero;

while (numeroActual > 0)
{
    int digito = numeroActual % 10;
    sumaDigitos += digito;
    numeroActual /= 10;
}

Console.WriteLine("La suma de los dígitos de " + numero + " es: " + sumaDigitos);
