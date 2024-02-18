// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número entero mayor o igual a 100");
Console.WriteLine();

Console.WriteLine("Ingrese la cantidad de números que desea sumar : ");


int n = int.Parse(Console.ReadLine());

int sumatoria = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ingrese el número {i + 1}:");
    int numero = int.Parse(Console.ReadLine());
    sumatoria += numero;
}

if (sumatoria >= 100)
{
    Console.WriteLine($"La sumatoria es {sumatoria} y es mayor o igual a 100.");
}
else
{
    Console.WriteLine($"La sumatoria es {sumatoria} y es menor que 100.");
}
