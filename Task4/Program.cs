 Console.Write("Vvedite razmer massiva: "); 
int n=int.Parse(Console.ReadLine());    
Console.WriteLine("Vvedite elementi massiva: "); 
int[] array=new int[n];
for(int i=0; i<n; i++)
{
    array[i]=int.Parse(Console.ReadLine()); 

}
for (int i = 0; i < n; i++)
{
	if (i%2==0)
	{
        Console.Write(array[i]+" ");
    }
}