namespace CodeKata4
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for(int i = 0; i <= n; i++)
            {
                if(i != 0 && n % i  == 0)
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            Solution s = new Solution();

            s.solution(n);

            Console.WriteLine(s.solution(n));

        }
    }
}