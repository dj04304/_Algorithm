using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
      public string solution(string my_string)
  {
      string answer = "";

      char[] chars = my_string.ToCharArray();
      HashSet<char> set = chars.ToHashSet();

      foreach(char c in set)
      {
          answer += c;
      }

      return answer;
  }
}