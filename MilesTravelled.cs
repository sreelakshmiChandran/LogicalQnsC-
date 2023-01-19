Console.WriteLine("Enter the passenger name: ");
string Name = Console.ReadLine();
Console.WriteLine("Total miles travelled: ");
decimal TotalMiles = Convert.ToDecimal(Console.ReadLine());

if (TotalMiles > 10000 && TotalMiles < 20000)
{
    Console.WriteLine(Name + " awards 10 frequent flyer points");
}

 else if (TotalMiles > 20000 && TotalMiles < 50000)
{
    Console.WriteLine(Name + " awards 20 frequent flyer points");
}

else if (TotalMiles > 50000 && TotalMiles < 100000)
{
    Console.WriteLine(Name + " awards 30 frequent flyer points");
}

else if (TotalMiles > 100000)
{
    Console.WriteLine(Name + " awards 50 frequent flyer points");
}
