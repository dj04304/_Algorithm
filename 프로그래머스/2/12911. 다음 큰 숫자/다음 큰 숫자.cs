using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int n)
    {

        string a = Convert.ToString(n, 2);
        int num = 0;

        int answer = 0;

        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] == '1')
                num++;
        }

        // answer > n

        while(true)
        {
            int num2 = 0;
            n++;

            string b = Convert.ToString(n, 2);
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] == '1')
                    num2++;
            }

            if(num == num2)
            {
                answer = n;
                break;
            }

        }



        // n보다 크고 a의 1의 개수와 같은 가장 작은 수

        return answer;
    }
}