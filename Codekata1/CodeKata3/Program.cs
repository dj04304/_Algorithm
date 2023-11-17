namespace CodeKata3
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                string str = n.ToString();

                for(int i = 0; i < str.Length; i++)
                {
                    answer += (int)Char.GetNumericValue(str[i]);
                }
                
                return answer;
            }
        }
        static void Main(string[] args)
        {
            int n = 123;
            Solution s = new Solution();
            s.solution(n);

            Console.WriteLine(s.solution(n));
        }
    }
}