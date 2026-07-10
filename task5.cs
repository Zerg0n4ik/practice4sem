using System;
 
class Program
{
    const int MOD = 1000000007;
 
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
 
        int[] dp = new int[n + 1];
        dp[0] = 1;
 
        long Sum = 1;
 
        for (int i = 1; i <= n; i++)
        {
            dp[i] = (int)(Sum % MOD);
            Sum = (Sum + dp[i]) % MOD;
 
            if (i >= k)
            {
                Sum = (Sum - dp[i - k] + MOD) % MOD;
            }
        }
 
        Console.WriteLine(dp[n]);
    }
}
