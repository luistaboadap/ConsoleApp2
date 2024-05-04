
// Calcula la suma de los números pares en un rango especificado por el usuario. 
Console.WriteLine("Ingrese numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese numero: ");
int num2 = int.Parse(Console.ReadLine());
int sumPar = 0, n1 = num1 + 1, n2 = num2 - 1;

while (n1 <= n2)
{
    if (n1 % 2 == 0)
    {
        sumPar += n1;
    }
    n1++;
}
Console.Write(sumPar + num1 + num2);
Console.ReadKey();

