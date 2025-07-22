using System.Numerics;

public class Solution
{
   public int solution(int balls, int share)
{
    if (share > balls) return 0;

    long numerator = 1;
    long denominator = 1;

    if (share > balls - share)
        share = balls - share;

    for (int i = 1; i <= share; i++)
    {
        numerator *= balls - i + 1;
        denominator *= i;

        long gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    return (int)(numerator / denominator);
}

long GCD(long a, long b)
{
    while (b != 0)
    {
        long temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
}