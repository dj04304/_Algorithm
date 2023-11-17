namespace CodeKata6
{
    internal class Program
    {
        public class Solution
        {
            public long[] solution(int x, int n)
            {
                long[] answer = new long[n];
                answer[0] = x;

                for(int i = 1; i < n; i++)
                {
                    answer[i] = answer[i - 1] + x;
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            int x = 2;
            int n = 5;

            Solution s = new Solution();
            long[] result = s.solution(x, n);

            foreach(int i in result) {

            Console.WriteLine(i);
            }

        }
    }
}