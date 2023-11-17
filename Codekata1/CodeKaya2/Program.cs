namespace CodeKata2
{
    internal class Program
    {
        public class Solution
        {
            public double solution(int[] arr)
            {
                double answer = 0;
                double sum = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                answer = sum / arr.Length;

                return answer;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            Solution s = new Solution();
            
            s.solution(arr);

            Console.WriteLine(s.solution(arr));

        }
    }
}