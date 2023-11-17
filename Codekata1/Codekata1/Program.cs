using System;

namespace Codekata1
{
    internal class Program
    {
        public class Solution
        {
            public string solution(int num)
            {
                string answer = "";

                if(num % 2 == 0)
                {
                    answer = "Even";
                }
                else
                {
                    answer = "Odd";
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            int input = int.Parse(Console.ReadLine());

            solution.solution(input);

            string result = solution.solution(input);

            Console.WriteLine(result);

        }
    }
}