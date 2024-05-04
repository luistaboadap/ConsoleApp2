// Toma una cadena de texto y muestra su inversión. 
Console.WriteLine("Ingrese texto: ");
string s = Console.ReadLine();
int i = s.Length - 1;
string aux = " ";
while (i >= 0)
{
    aux = aux + s[i];
    i = i - 1;
}
Console.WriteLine(aux);

