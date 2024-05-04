
// Calcular una funcion que calcule el factorial de un numero
Console.WriteLine("Ingresar el numero: ");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("el factorial de " + num + " es " + factorial);
Console.ReadLine();

