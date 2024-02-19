 int EvenCount(int n)
{
    int evenNumbers = 0;
    while (n > 0)
    {
        if ((n % 10) % 2 == 0 && (n % 10) != 0)
        {
            evenNumbers++;

        }

        n /= 10;
    }
    return evenNumbers;
}
int OddCount(int n)
{
    int oddNumbers = 0;
    while (n > 0)
    {
        if ((n % 10) % 2 != 0)
        {
            oddNumbers++;

        }

        n /= 10;
    }
    return oddNumbers;
}
int ZeroCount(int n)
{
    int zeroCount = 0;
    while (n > 0)
    {
        if ((n % 10) == 0)
        {
            zeroCount++;

        }

        n /= 10;
    }
    return zeroCount;
}
int DigitCount(int n)
{
    int digitCount = 0;
    while (n>0)
    {
        digitCount++; 
        n /= 10;
    } 
    return digitCount;
}
int MinDigit(int n)
{
    int minValue = int.MaxValue;
    while (n>0)
    {
        if (n % 10 < minValue)
        {
            minValue = n % 10;
        }
        n /= 10;
    }
    return minValue;
   
}
int MaxDigit(int n)
{
    int maxValue = int.MinValue;
    while (n > 0)
    {
        if (n % 10 > maxValue)
        {
            maxValue = n % 10;
        }
        n /= 10;
    }
    return maxValue;

}


int SumOfdigit(int n)
{
    int sum = 0;
    while (n>0)
    {
        sum += n % 10; 
        n /= 10;
    }
    return sum;
}
Console.Write("Vvedite chislo: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Even: {EvenCount(n)}\nOdd: {OddCount(n)}\nZeros: {ZeroCount(n)}\n" +
    $"Digits: {DigitCount(n)}\nMin: {MinDigit(n)}\nMax: {MaxDigit(n)}\nSum of Digits: {SumOfdigit(n)}");