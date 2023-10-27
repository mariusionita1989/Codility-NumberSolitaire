using System.Runtime.CompilerServices;

namespace Codility_NumberSolitaire
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 2;
        private const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int[] dp = new int[N];
                // Initialize the dp array with minimum integer values
                for (int i = 0; i < N; i++)
                    dp[i] = int.MinValue;

                dp[0] = A[0]; // Start with the value of the first square
                for (int i = 0; i < N; i++)
                {
                    for (int j = 1; j <= 6; j++)
                    {
                        if (i + j < N)
                            dp[i + j] = Math.Max(dp[i + j], dp[i] + A[i + j]);
                    }
                }

                return dp[N - 1];
            }

            return -1; // this means the initial conditions were not met; N it is not valid
        }
    }
}
