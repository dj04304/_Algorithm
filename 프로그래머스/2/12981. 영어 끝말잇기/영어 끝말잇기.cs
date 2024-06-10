using System;
using System.Collections.Generic;

class Solution
{
                     public int[] solution(int n, string[] words)
            {
                HashSet<string> usedWords = new HashSet<string>();
                int turn = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    // 현재 말한 사람의 번호와 차례 계산
                    int player = i % n + 1;
                    int round = i / n + 1;

                    // 현재 단어
                    string currentWord = words[i];

                    // 이전 단어의 마지막 문자와 현재 단어의 첫 문자 비교
                    if (i > 0 && words[i - 1][words[i - 1].Length - 1] != currentWord[0])
                    {
                        return new int[] { player, round };
                    }

                    // 이미 사용된 단어인지 확인
                    if (usedWords.Contains(currentWord))
                    {
                        return new int[] { player, round };
                    }

                    // 단어를 사용된 단어 집합에 추가
                    usedWords.Add(currentWord);
                }

                // 탈락자가 없는 경우
                return new int[] { 0, 0 };
            }   
}