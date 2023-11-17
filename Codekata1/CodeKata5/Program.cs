namespace CodeKata5
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;

                for(int  i = 1; i < n + 1; i++)
                {
                    if(n % i == 1)
                    {
                        answer = i;
                        break;
                    }

                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            int n = 10;
           Solution s = new Solution();

            s.solution(n);

            Console.WriteLine(s.solution(n));

        }
    }
}