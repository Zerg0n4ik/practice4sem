using System;
 
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
 
        for (int test = 0; test < t; test++)
        {
            string[] input = Console.ReadLine().Split();
            int[] a = new int[7];
            int sum = 0;
 
            for (int i = 0; i < 7; i++)
            {
                a[i] = int.Parse(input[i]);
                sum += a[i];
            }
 
            int maxSum = int.MinValue;
            for (int i = 0; i < 7; i++)
            {
                int[] temp = new int[7];
                for (int j = 0; j < 7; j++)
                {
                    temp[j] = a[j];
                }
 
                for (int j = 0; j < 7; j++)
                {
                    if (j != i)
                    {
                        temp[j] = -temp[j];
                    }
                }
 
                int currentSum = 0;
                for (int j = 0; j < 7; j++)
                {
                    currentSum += temp[j];
                }
 
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
 
            Console.WriteLine(maxSum);
        }
    }
}
