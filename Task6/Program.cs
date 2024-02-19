Console.Write("Vvedite razmer massiva: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("===============================");
for (int i = 0; i < size; i++)
{
    bool find = false;

    int k = i + 1;
    for (int j = i + 1; j < size; j++)
    {
        if (array[i] == array[j])
        {
            find = true;
            Console.Write(array[j] + " ");

            int c = array[k];
            array[k] = array[j];
            array[j] = c;
            k++;
            i++;
        }
    }

    if(find)
        Console.Write(array[i] + " ");
}