using System;
using System.Numerics;

public class Solution {
    public string solution(string a, string b)
    {
        string answer = "";

        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;


        while(i >= 0 ||  j >= 0 || carry > 0)
        {
            int digitA = (i >= 0) ? a[i--] - '0' : 0;
            int digitB = (j >= 0) ? b[j--] - '0' : 0;

            int sum = digitA + digitB + carry;
            answer = (sum % 10) + answer;
            carry = sum / 10;

        }

        return answer;
    }
}