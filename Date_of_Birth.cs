Console.WriteLine("Enter the DOB: ");
var dob = DateTime.Parse(Console.ReadLine());

var today = DateTime.Today;
Console.WriteLine(today);

Console.WriteLine("Age in years: " + (today.Year - dob.Year));
Console.WriteLine("Age in months: " + (today.Year - dob.Year) * 12);
Console.WriteLine("Age in weeks: " + (today.Year - dob.Year) * 52);
Console.WriteLine("Age in days: " + (today.Year - dob.Year) * 365);
Console.WriteLine("Age in hours: " + ((today.Year - dob.Year) * 365) * 24);

var year = dob.Year;
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)

    Console.WriteLine("Leap year");

else
    Console.WriteLine("Not a leap year");

