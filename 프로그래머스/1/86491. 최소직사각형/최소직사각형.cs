using System;

        public class Solution
        {
            public int solution(int[,] sizes)
            {

                int row = 0;
                int col= 0;
                int answer = 0;

                for (int i = 0; i < sizes.GetLength(0); i++)
                {
                    int width = sizes[i,0];
                    int height = sizes[i,1];

                    if (height > width)
                    {
                        width = sizes[i, 1];
                        height = sizes[i, 0];
                    }
                    if (width > row)
                    {
                        row = width;
                    }

                    if(height > col)
                    {
                        col = height;
                    }
                    
                }


                answer = row * col;

                return answer;
            }
        }