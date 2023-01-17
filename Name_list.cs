//using System;

using System;
using System.Collections.Immutable;

string[] List = new string[5];
int i = 0;
for(i = 0;i < 5; i++)
{
    Console.WriteLine("Enter the name:");
    string Name = Console.ReadLine();
    List[i] = Name;
}
foreach(string Name in List)
    Console.WriteLine(Name);

Array.Sort(List);
Console.WriteLine("Ascending order:");
foreach (string Name in List)
{
    Console.WriteLine(Name);
}
    

Array.Reverse(List);
Console.WriteLine("Reverse order:");
foreach (string Name in List)
{
    Console.WriteLine(Name);
}


string NewName = ("Appu");
foreach(string Name in List)
    if(Name == NewName)
        Console.WriteLine(Name);



Boolean f = false;
string dup = "";
for (i = 0; i < 5; i++)
{
    for (int j = i+1; j < 5; j++)
    {
        if (List[i] == List[j])
        {
            f = true;
            dup = List[i];
            break;
        }
    }
}
if (f == true)
{
    Console.WriteLine("Duplicate entry: " + dup);
}
else
    Console.WriteLine("No duplicates");



Console.WriteLine("Write something with space");
string forSplit = Console.ReadLine();
var splited = forSplit.Split(" ");
Array.ForEach(splited, s => Console.WriteLine(s));  
