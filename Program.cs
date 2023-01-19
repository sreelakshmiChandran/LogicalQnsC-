decimal[] farelist = new decimal[4];

int i = 0;
int j = 0;
int k = 1;
decimal[] newArray = new decimal[8];
for (i = 0; i < farelist.Length; i++)
{
    Console.WriteLine("Enter the fare:");
    decimal fare = Convert.ToDecimal(Console.ReadLine());
    farelist[i] = fare;
}
foreach (var item in farelist)
{
    if (item % 2 == 0)
    {
        newArray[j] = item;
        j += 2;
    }
    else
    {
        newArray[k] = item;
        k += 2;
    }
}
Console.WriteLine("Fare list: ");
foreach (var item in newArray)
{
    Console.WriteLine(item);
}





