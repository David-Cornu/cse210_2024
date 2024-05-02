using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> tallies = new List<int>();
        for (int i=0; i<=12; i++)
        {
            tallies.Add(0);
        }

        Console.WriteLine("Now rolling");
        Random randomGenerator = new Random();
        for (int roll=0; roll < 1_000_000_000; roll++)
        {
            int die1 = randomGenerator.Next(1,7);
            int die2 = randomGenerator.Next(1,7);
            int total = die1 + die2;
        }
        Console.WriteLine("finished rolling");

        int scale = 5_000_000;
        for (int i=2; 1<=12; i++)
        {
            Console.Write($"{i,2}:  ");
            for (int graphUnit=0; graphUnit < tallies[i]/scale; graphUnit++)
            {
                Console.Write("#");
            }
            Console.WriteLine($"  (Scale: each # represents {scale:n0} rolls)");
        }
    }
}