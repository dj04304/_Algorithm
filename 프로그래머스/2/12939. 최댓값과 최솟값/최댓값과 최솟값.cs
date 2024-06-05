using System.Linq;
public class Solution
{
 public string solution(string s)
 {
     int[] nums = s.Split(' ').Select(int.Parse).ToArray();

     int min = nums.Min();
     int max = nums.Max();

     string answer = $"{min} {max}";

     return answer;
 }
}