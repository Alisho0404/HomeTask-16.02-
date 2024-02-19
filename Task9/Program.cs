 int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return a * Power(a, b - 1);
    }
}
Console.Write("Input the base value: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input the exponent: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"The value of {a} to the power of {b} is: {Power(a, b)}");