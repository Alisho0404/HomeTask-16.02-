 Console.Write("Vvedite n: ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine($"Vvedite {n} cifr");
int[] array = new int[n]; 
for (int i=0; i<n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int negative = 0;
int positive = 0;
int zeros = 0;
int even = 0;
int odd = 0;
int max = array[0]; 
int min = array[0];
int sum = 0;
for (int i=0; i<n; i++)
{
    if (array[i] < 0) negative++;

    if (array[i] > 0) positive++;
     
    if (array[i] == 0) zeros++;
    if (array[i] % 2 == 0 && array[i]!=0) even++; 
    if (array[i] %2!=0) odd++;
    if (array[i] > max) max = array[i];
     
    if (array[i] < min) min = array[i];
    sum += array[i];
}
Console.WriteLine($"Negative = {negative}\nPositive = {positive}\nZeros = {zeros}\nEven = {even}\n" +
    $"Odd = {odd}\nMax = {max}\nMin = {min}\nSum of Digits = {sum}");