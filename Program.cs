using System.Collections;

ArrayList flightNumber = new ArrayList();
int count = 0;
while (count == 0)
{
    Console.WriteLine("1.Flight number");
    Console.WriteLine("2.View");
    Console.WriteLine("3.Quit");

    Console.WriteLine("Enter the input: ");
    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {

        case 1:
            Console.WriteLine("Enter the flight number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            flightNumber.Add(num);
            break;

        case 2:
            Console.WriteLine("View the flight numbers: ");
            foreach (var item in flightNumber)
            {
                Console.WriteLine(item);
            }

            break;

        case 3:
            count = 1;
            break;

        default:
            Console.WriteLine("Invalid");
            break;
    }
}