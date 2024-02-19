int Fibonachi(int a)
{
    if (a <= 1)
        return a;
    else
        return Fibonachi(a - 1) + Fibonachi(a - 2);

}
Console.Write("Input the number: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"The Fibonacci series of {a} terms is: ");
for (int i = 0; i < a; i++)
{
    Console.Write($"{Fibonachi(i)} ");

}
 