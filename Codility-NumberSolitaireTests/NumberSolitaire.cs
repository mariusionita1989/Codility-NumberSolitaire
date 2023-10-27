using Codility_NumberSolitaire;

namespace Codility_NumberSolitaireTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestValidExample()
        {
            int[] A = { 1, -2, 0, 9, -1, -2 };
            int expected = 8;
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMinimumInput()
        {
            int[] A = { 1, 2 };
            int expected = 3;
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMaximumInput()
        {
            int[] A = new int[100000]; // All zeros
            int expected = 0;
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestInvalidInput()
        {
            int[] A = { 1 };
            int expected = -1;
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}