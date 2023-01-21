using System.Globalization;

string[] names = new string[10];
string[] destinations = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter the passenger name: ");
    names[i] = Console.ReadLine();
    Console.WriteLine("Enter the desination: ");
    destinations[i] = Console.ReadLine();
}

int j = 0;
int k = 1;
string[] newArray = new string[20];
for (int i = 0; i < 10; i++)
{
    newArray[j] = names[i];
    j += 2;
    newArray[k] = destinations[i];
    k += 2;
}
Console.WriteLine("The names and desinations are:");
foreach (var item in newArray)
{
    Console.WriteLine(item);
}