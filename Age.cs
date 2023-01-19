DateTime[] DOB = new DateTime[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Date of Birth: ");
    DOB[i] = Convert.ToDateTime(Console.ReadLine());
}
foreach(DateTime i in DOB)
{
    var today = DateTime.Today;
    TimeSpan interval = today - i;
    int Age = (interval.Days) / 365;

    if(Age <= 10)
    {
        Console.WriteLine("Passenger is kid");
    }
    else if (Age > 10 && Age <= 30)
    {
        Console.WriteLine("Passenger is Youth");
    }
    else if (Age > 30 && Age <= 60)
    {
        Console.WriteLine("Passenger is Adult");
    }
    else if (Age > 60)
    {
        Console.WriteLine("Passenger is Older");
    }
}
