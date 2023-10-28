using Codility_CountDistinctSlices;

namespace Codility_CountDistinctSlicesTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestSolution_Example1()
        {
            Solution solution = new Solution();
            int M = 6;
            int[] A = { 3, 4, 5, 5, 2 };
            int expected = 9;
            int result = solution.solution(M, A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolution_SingleElement()
        {
            Solution solution = new Solution();
            int M = 3;
            int[] A = { 2 };
            int expected = 1;
            int result = solution.solution(M, A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolution_AllElementsDistinct()
        {
            Solution solution = new Solution();
            int M = 5;
            int[] A = { 1, 2, 3, 4, 5 };
            int expected = 15;
            int result = solution.solution(M, A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolution_EmptyArray()
        {
            Solution solution = new Solution();
            int M = 2;
            int[] A = new int[] { };
            int expected = 0;
            int result = solution.solution(M, A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSolution_LargeInput()
        {
            Solution solution = new Solution();
            int M = 100000;
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                A[i] = i % 10; // Create a repeating pattern for elements
            }
            int expected = 999955;
            int result = solution.solution(M, A);
            Assert.Equal(expected, result);
        }
    }
}