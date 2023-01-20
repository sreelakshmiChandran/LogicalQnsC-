using System.Collections;

decimal[] PassNumber = new decimal[11];
for(int i = 0;i < PassNumber.Length; i++)
{
    Console.WriteLine("Enter the Boarding Pass Number: ");
    PassNumber[i] = Convert.ToDecimal(Console.ReadLine());
}

Queue Number1 = new Queue();
Queue Number2 = new Queue();
Queue Number3 = new Queue();

for(int i =0;i < PassNumber.Length;i++)
{
    if(Number1.Count < 3)
    {
        Number1.Enqueue(PassNumber[i]);
    }

    else if(Number2.Count < 3)
    {
        Number2.Enqueue(PassNumber[i]);
    }
    else if(Number3.Count < 3)
    {
        Number3.Enqueue(PassNumber[i]);
    }
    else
    {
        Random r = new Random();
        int k = r.Next(1,3);
        if(k == 1) 
        { 
            Number1.Dequeue();
            Number1.Enqueue(PassNumber[i]);
        }
        else if(k == 2)
        {
            Number2.Dequeue();
            Number2.Enqueue(PassNumber[i]);
        }
        else if (k == 3)
        {
            Number3.Dequeue();
            Number3.Enqueue(PassNumber[i]);
        }
        
    }
    
}
foreach (var c in Number1)
{
    Console.WriteLine(c);
}
foreach (var c in Number2)
{
    Console.WriteLine(c);
}
foreach (var c in Number3)
{
    Console.WriteLine(c);
}
