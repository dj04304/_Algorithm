using System;
using System.Collections.Generic;

public class Solution {
        public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;
        int n = discount.Length;
        int day = 10;


        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < want.Length; i++)
        {
            dic.Add(want[i], number[i]);
        }

        for(int i = 0; i <= n - day; i++)
        {
            Dictionary<string, int> copyDic = new Dictionary<string, int>(dic);

            for(int j = i; j < i + day; j++)
            {
                if (copyDic.ContainsKey(discount[j]))
                {
                    copyDic[discount[j]]--;

                    if (copyDic[discount[j]] == 0)
                        copyDic.Remove(discount[j]);
                }
            }

            if(copyDic.Count == 0)
                answer++;

        }


        return answer;
    }
}