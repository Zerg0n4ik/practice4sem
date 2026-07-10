using System;
 
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
 
        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
 
            for (int j = 0; j < 5; j++)
            {
                if (a <= b && a <= c)
                    a++;
                else if (b <= a && b <= c)
                    b++;
                else
                    c++;
            }
 
            Console.WriteLine(a * b * c);
        }
    }
}
