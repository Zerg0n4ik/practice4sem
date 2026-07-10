using System;
 
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
 
        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int a = int.Parse(input[1]);
            int b = int.Parse(input[2]);
 
            if (b < 2 * a)
            {
                int pairs = n / 2;
                int remainder = n % 2;
 
                int total = pairs * b + remainder * a;
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine(n * a);
            }
        }
    }
}
