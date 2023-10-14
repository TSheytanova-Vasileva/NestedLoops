int floor = int.Parse(Console.ReadLine());
int estat = int.Parse(Console.ReadLine());


for (int i = floor; i >= 1; i -= 1)
{
    for (int j = 0; j < estat; j += 1)
    {
        if  (i == floor)
        {

            Console.Write($"L{i}{j} ");
        }
        else if (i % 2 == 0)
        {

            Console.Write($"O{i}{j} ");
        }
        else 

        {

            Console.Write($"A{i}{j} ");
        }
        
    }
    Console.WriteLine();
}
    


   
    
