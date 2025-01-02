using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
     public string solution(int[] numbers)
 {
     string[] nums = numbers.Select(num => num.ToString()).ToArray();

     Array.Sort(nums, (a, b) => string.Compare(b + a, a + b));

     if (nums[0] == "0") return "0";

     return string.Join("", nums);

 }
}