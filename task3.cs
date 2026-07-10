using System;
 
class Program
{
    const int MOD = 1000000007;
 
    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        int n = int.Parse(str[0]);
        int m = int.Parse(str[1]);
        int k = int.Parse(str[2]);
 
        bool[,] isDangerous = new bool[n + 1, m + 1];
 
        for (int i = 0; i < k; i++)
        {
            string[] str2 = Console.ReadLine().Split();
            int x = int.Parse(str2[0]);
            int y = int.Parse(str2[1]);
            isDangerous[x, y] = true;
        }
 
        long[,] dp = new long[n + 1, m + 1];
 
        if (!isDangerous[0, 0])
            dp[0, 0] = 1;
 
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                if (isDangerous[i, j])
                {
                    dp[i, j] = 0;
                    continue;
                }
 
                if (i == 0 && j == 0)
                    continue;
 
                long sum = 0;
 
                if (i > 0)
                    sum = (sum + dp[i - 1, j]) % MOD;
 
                if (j > 0)
                    sum = (sum + dp[i, j - 1]) % MOD;
 
                dp[i, j] = sum;
            }
        }
 
        Console.WriteLine(dp[n, m]);
    }
}
