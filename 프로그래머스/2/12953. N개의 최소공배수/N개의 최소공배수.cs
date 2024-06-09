using System;
using System.Linq;

public class Solution {
   public int solution(int[] arr)
   {
       return arr.Aggregate((lcm, next) => LCM(lcm, next));
   }

   private int GCD(int a, int b)
   {
       while (b != 0)
       {
           int temp = b;
           b = a % b;
           a = temp;
       }
       return a;
   }

   private int LCM(int a, int b)
   {
       return a * (b / GCD(a, b));
   }
}