
Console.WriteLine("Enter the fare:");
double Fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the time:");
double Time = Convert.ToDouble(Console.ReadLine());

if(Time >= 6 && Time < 9)
{
    double NewFare = Fare + (Fare * .1);
    Console.WriteLine(NewFare);
}

else if(Time >= 9 && Time < 17)
{
    double NewFare = Fare + (Fare * .2);
    Console.WriteLine(NewFare);
}

else if (Time >= 17 && Time < 23)
{
    double NewFare = Fare + (Fare * .07);
    Console.WriteLine(NewFare);
}

else if (Time >= 23 && Time < 6)
{
    double NewFare = Fare + (Fare * .05);
    Console.WriteLine(NewFare);
}
else
    Console.WriteLine("Invalid time");