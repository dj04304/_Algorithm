using System;   
public class Solution
    {
        // indexOf(배열, 찾는배열) 배열과 찾는 배열의 값을 받아 위치한 index를 반환
        public string solution(string[] seoul)
        {
            string answer = $"김서방은 {Array.IndexOf(seoul, "Kim")}에 있다";

            return answer;
        }
    }