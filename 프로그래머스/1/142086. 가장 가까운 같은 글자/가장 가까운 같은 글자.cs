using System;

        public class Solution
        {
            
            public int[] solution(string s)
            {
                /// banana 반복을 돌림
                /// temp라는 배열에 현재 단어를 담고 비교를 해야함
                char[] chars = s.ToCharArray();
                char[] temp = new char[chars.Length];

                int[] answer = new int[chars.Length];

                for (int i = 0; i < chars.Length; i++)
                {
                    /// 첫번째 단어는 계산없이 넣는다.
                    if(i == 0)
                    {
                        temp[i] = chars[i];
                        answer[i] = -1;
                    }
                    else
                    {
                        temp[i] = chars[i];
                        int index = i - 1;
                        while (true) 
                        {

                            if (index < 0)
                            {
                                break;
                            }

                            if (temp[index] == chars[i])
                            {
                                answer[i] = i - index;
                                break;
                            }
                            else
                            {
                                answer[i] = -1;
                            }
                            index--;
                        } 

                    }

                    

                }

                
                return answer;
            }
        }