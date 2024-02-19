 Console.Write("Vvedite razmer massiva: "); 
int n=int.Parse(Console.ReadLine());    
Console.WriteLine("Vvedite elementi massiva: "); 
int[] array=new int[n];
for(int i=0; i<n; i++)
{
    array[i]=int.Parse(Console.ReadLine()); 

}
int count = 0;
for (int i = 0; i < n-1; i++)
{
	if (array[i] < array[i+1])
	{
		count++;
	}
}
Console.WriteLine(count);