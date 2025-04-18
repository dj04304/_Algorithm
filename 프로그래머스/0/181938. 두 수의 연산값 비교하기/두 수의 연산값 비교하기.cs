using System;

public class Solution {
    public int solution(int a, int b) {
         int answer = 0;

  string s = a.ToString() + b.ToString();

  int sum = int.Parse(s);

  int multi = 2 * a * b;

  return answer = sum > multi ? sum : multi;
    }
}