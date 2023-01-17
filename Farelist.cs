decimal[] FareList = new decimal[4];
int i = 0;
for(i = 0;i < 4; i++)
{
    Console.WriteLine("Enter the fare:");
    decimal Fare = Convert.ToDecimal(Console.ReadLine());
    FareList[i] = Fare;
}

foreach(decimal Fare in FareList)
    Console.WriteLine(Fare);

Array.Sort(FareList);
Console.WriteLine("The ascending order of fare:");
foreach(decimal Fare in FareList)
{
    Console.WriteLine(Fare);
}
Console.WriteLine("The minimum fare is " + FareList[0]);


Array.Reverse(FareList);
Console.WriteLine("The reverse order of fare:");
foreach(decimal Fare in FareList)
{
    Console.WriteLine(Fare);
}
Console.WriteLine("The maximum fare is " + FareList[0]);


decimal NewFare = 7895;
foreach(decimal Fare in FareList)
    if(Fare == NewFare)
        Console.WriteLine(Fare);

Boolean  f = false;
decimal dup = 0;
for (i = 0;i < FareList.Length; i++)
{
    for (int j = i + 1; j < FareList.Length; j++)
    {
        if (FareList[i] == FareList[j])

        {
            f = true;
            dup = FareList[i];
            break;
        }
    }  
}
   
if(f == true)
{
    Console.WriteLine("The duplicate entry is:" + dup );
}
else
{
    Console.WriteLine("No duplicate");
}

