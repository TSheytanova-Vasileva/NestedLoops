int number = int.Parse(Console.ReadLine());
int count = 1;
for (int row = 1; true; row += 1)
{

    for (int col = 1; col <= row; col += 1)

    {
        Console.Write($"{count} ");
        count += 1;

    
    if (count > number)
    {
        break;
    }
}
    Console.WriteLine();
    if (count > number)
    {
        break;
    }
}
