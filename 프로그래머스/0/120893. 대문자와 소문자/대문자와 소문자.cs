using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
         return new string(my_string
     .Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))
     .ToArray()); ;
    }
}