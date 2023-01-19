string[] Desinations = new string[3];
decimal[] FareList = new decimal[3];
int i = 0;
for(i = 0;i < 3; i++)
{
    Console.WriteLine("Desination: ");
    Desinations[i] = Console.ReadLine();
    Console.WriteLine("Enter the flight fare: ");
    FareList[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Enter the nth index: ");
int d = Convert.ToInt32(Console.ReadLine());


if(d > 3)
{
    Console.WriteLine("Invalid Index");
}
else
{
    Console.WriteLine("Desination: " + Desinations[d]);
    Console.WriteLine("Flight fare: " + FareList[d]);
}
