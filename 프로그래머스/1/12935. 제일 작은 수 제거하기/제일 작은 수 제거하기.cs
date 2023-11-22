using System.Collections.Generic;
using System.Linq;

        public class Solution
        {
            public int[] solution(int[] arr)
            {
                List<int> array = new List<int>(arr);
                
                int min = arr.Min();

                array.Remove(min);
                
                if(array.Count == 0) 
                {
                    array.Add(-1);
                }

                return array.ToArray();
            }
        }