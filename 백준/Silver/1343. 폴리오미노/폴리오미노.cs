using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        StringBuilder answer = new StringBuilder();

        int countX = 0;  // 연속된 'X'의 개수를 세기 위한 변수

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'X')
            {
                countX++;
            }
            else
            {
                // 연속된 'X'를 처리
                if (countX > 0)
                {
                    if (countX % 2 != 0)
                    {
                        answer.Clear();
                        answer.Append("-1");
                        break;
                    }

                    while (countX >= 4)
                    {
                        answer.Append("AAAA");
                        countX -= 4;
                    }
                    if (countX == 2)
                    {
                        answer.Append("BB");
                        countX -= 2;
                    }

                    countX = 0;
                }

                // '.'를 처리
                answer.Append('.');
            }
        }

        // 마지막 연속된 'X' 처리
        if (countX > 0)
        {
            if (countX % 2 != 0)
            {
                answer.Clear();
                answer.Append("-1");
            }
            else
            {
                while (countX >= 4)
                {
                    answer.Append("AAAA");
                    countX -= 4;
                }
                if (countX == 2)
                {
                    answer.Append("BB");
                    countX -= 2;
                }
            }
        }

        Console.WriteLine(answer.ToString());
    }
}
