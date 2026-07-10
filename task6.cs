using System;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] cost = new int[n, n];
 
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                cost[i, j] = int.Parse(row[j]);
            }
        }
 
        int size = 1 << n;
        int[,] dp = new int[size, n];
 
        for (int mask = 0; mask < size; mask++)
        {
            for (int i = 0; i < n; i++)
            {
                dp[mask, i] = int.MaxValue / 2;
            }
        }
 
        dp[1, 0] = 0;
 
        for (int mask = 1; mask < size; mask++)
        {
            for (int i = 0; i < n; i++)
            {
                if (dp[mask, i] == int.MaxValue / 2) continue;
 
                for (int j = 0; j < n; j++)
                {
                    if ((mask & (1 << j)) == 0)
                    {
                        int newMask = mask | (1 << j);
                        int newCost = dp[mask, i] + cost[i, j];
                        if (newCost < dp[newMask, j])
                        {
                            dp[newMask, j] = newCost;
                        }
                    }
                }
            }
        }
 
        int fullMask = (1 << n) - 1;
        int answer = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            answer = Math.Min(answer, dp[fullMask, i] + cost[i, 0]);
        }
 
        Console.WriteLine(answer);
    }
}
