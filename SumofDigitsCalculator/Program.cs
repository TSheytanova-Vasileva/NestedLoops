
string command = Console.ReadLine();

while (command != "End")
{
    int number = int.Parse(command);
    int sum = 0;

    for (int num = number; num > 0; num /= 10)
    {
        int digit = num % 10;
        sum += digit;
    }

    Console.WriteLine($"Sum of digits = {sum}");

    command = Console.ReadLine();
}

Console.WriteLine("Goodbye");
        
    
