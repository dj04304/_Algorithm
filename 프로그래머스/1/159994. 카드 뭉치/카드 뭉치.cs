using System;

      public class Solution
      {

          public string solution(string[] cards1, string[] cards2, string[] goal)
          {
              /// 무조건 앞에서 부터 꺼내써야함
              /// 한장씩 꺼내기
              /// 순서가 맞으면 yes 아니면 no
              /// 
              string answer = "Yes";

              int card1index = 0;
              int card2index = 0;

              for(int i = 0; i < goal.Length; i++)
              {
                  if (card1index < cards1.Length && cards1[card1index] == goal[i])
                  {

                      card1index++;
                      continue;
                  }
                  else if (card2index < cards2.Length && cards2[card2index] == goal[i])
                  {
                      card2index++;
                      continue;
                  }
                  else
                  {
                      return "No";
                  }

              }

              return answer;
          }
      }