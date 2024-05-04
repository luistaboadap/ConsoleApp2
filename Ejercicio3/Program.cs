// Calcular el area de un triangulo
Console.WriteLine("Ingresar la base del triangulo: ");
int base_t = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo: ");
int altura = int.Parse(Console.ReadLine());
double area = (base_t * altura) / 2;
Console.WriteLine("el area del triangulo es: " + area + " cm2");
Console.ReadKey();

