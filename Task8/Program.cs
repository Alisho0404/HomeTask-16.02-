 int Sum(int a, int b) { return a + b; }
int Subtract(int a, int b) { return a - b; }
int Multiplication(int a, int b) { return (a * b); }
int Division(int a, int b) { return (a / b); }

static void Main(string[] args) { }
Console.Write("The first number is: ");
int a = int.Parse(Console.ReadLine());

Console.Write("The second number is: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter operation(+, -, *, /): ");
char operation = char.Parse(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine($"{a} + {b} = {Sum(a, b)}");
        break;

    case '-':
        Console.WriteLine($"{a} - {b} = {Subtract(a, b)}");
        break;

    case '*':
        Console.WriteLine($"{a} * {b} = {Multiplication(a, b)}");
        break;

    case '/':
        Console.WriteLine($"{a} / {b} = {Division(a, b)}");
        break;
}
