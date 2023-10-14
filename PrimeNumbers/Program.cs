int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for  (int i = start; i < end; i+= 1)
{
    bool isPrme = true;

    int divider = 2;

    while (divider < end)
    {
        if ( i == divider )
        {
            divider += 1;
            continue;

        }
        if ( i % divider == 0)
        {
            isPrme = false;
            break;
        }
        divider += 1;
    }
    if ( isPrme )
    {
        Console.Write($"{ i} ");
    }
}
