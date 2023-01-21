int[] value = new int[5];
int i = 0;
for (i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the overweight: ");
    int overWeight = Convert.ToInt32(Console.ReadLine());
    value[i] = overWeight * 15;
}

Console.WriteLine("Value for overweight: ");
foreach(int c in value)
{
    Console.WriteLine(c);
}

for ( i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (value[i] > value[j])
        {
            int temp = value[i];
            value[i] = value[j];
            value[j] = temp;
        }
    }
}

Console.WriteLine("Sorted based on max value: ");
foreach (var item in value)
{
    Console.WriteLine(item);
    
}
Console.WriteLine("Maximum value: " + value[value.Length-1]);
