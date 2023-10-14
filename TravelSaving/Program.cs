string destination = Console.ReadLine();

while (destination != "End")
{

    double budjet = int.Parse(Console.ReadLine());
    double sum = 0;

    while (sum < budjet)
    {
        double sumToBeAdded = double.Parse(Console.ReadLine());
        sum += sumToBeAdded;

        Console.WriteLine($"Collected: {sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}




