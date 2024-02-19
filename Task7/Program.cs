 Console.Write("From = "); 
int x=int.Parse(Console.ReadLine());
Console.Write("To = "); 
int y=int.Parse(Console.ReadLine());

Console.WriteLine("-----------------------------------");
for (int j = 1; j < y; j++)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{x} x {i} = {x * i}");
    }
    x++;
    Console.WriteLine("-----------------------------------");
}

