// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fatoriais de 1 a 10");


int fatorial = 1;

for (int i = 1; i < 11; i++)
{
    fatorial *= i;
    Console.WriteLine($"Fatorial de {i} = {fatorial}");
}