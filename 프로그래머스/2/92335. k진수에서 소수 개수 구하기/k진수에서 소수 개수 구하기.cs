using System;

public class Solution
{
       public int solution(int n, int k)
    {
        string changeEssence = CustomEssenceChange(n, k);

        string[] parts = changeEssence.Split('0');

        int answer = 0;

        foreach(string part in parts ) 
        {
            if(!string.IsNullOrEmpty(part))
            {
                long number = long.Parse(part);
                if (IsPrime(number))
                    answer++;
            }
        
        }

        return answer;
    }

    public string CustomEssenceChange(int number, int k)
    {

        string chars = "0123456789";
        string result = "";


        while(number > 0)
        {
            result = chars[number % k] + result;
            number /= k;
        }

        return result == "" ? "0" : result;

    }

    public bool IsPrime(long number)
    {
        if (number < 2)
            return false;

        for(long i = 2; i * i <= number; i++)
        {
            if(number % i == 0)
                return false;
        }

        return true;

    }
}
