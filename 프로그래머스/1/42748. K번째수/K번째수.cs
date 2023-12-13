using System;

        public class Solution
        {
            public int[] solution(int[] array, int[,] commands)
            {
                int[] answer = new int[commands.GetLength(0)];

                int startIndex = 0;
                int endtIndex = 1;
                int selecteIndex = 2;

                for (int i = 0; i < commands.GetLength(0); i++)
                {
                    
                    int length = (commands[i, endtIndex] - commands[i, startIndex]) +1;

                    int[] copyArray = new int[length];

                    Array.Copy(array, commands[i, startIndex] - 1, copyArray, 0, length); // 배열 증가

                    Array.Sort(copyArray);

                    for(int j = 0; j < copyArray.Length; j++)
                    {
                        if(j == commands[i, selecteIndex] - 1)
                        {
                            answer[i] = copyArray[j] ;
                        }
                    }

                }


                
                return answer;
            }
        }