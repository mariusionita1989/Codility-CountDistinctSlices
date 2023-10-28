using System.Runtime.CompilerServices;

namespace Codility_CountDistinctSlices
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int M, int[] A)
        {
            int N = A.Length;
            int distinctSlices = 0;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE && M >= RANGE_LOWEST_VALUE - 1 && M <= RANGE_HIGHEST_VALUE) 
            {
                int[] occurrence = new int[M + 1]; // Keep track of the occurrence of each element in the current slice
                int left = 0;

                for (int right = 0; right < N; right++)
                {
                    while (occurrence[A[right]] > 0)
                    {
                        occurrence[A[left]]--;
                        left++;
                    }
                    occurrence[A[right]]++;
                    distinctSlices += (right - left + 1);

                    if (distinctSlices > 1000000000)
                        return 1000000000;
                }
            }
           
            return distinctSlices;
        }
    }
}
