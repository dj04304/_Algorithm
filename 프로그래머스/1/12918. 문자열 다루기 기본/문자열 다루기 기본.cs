using System;
        public class Solution
        {
            public bool solution(string s)
            {
                bool answer = false;

               if(Int32.TryParse(s, out int result) && (s.Length == 4 || s.Length ==6) )
                {
                    return answer = true;
                }


                return answer;
            }
        }