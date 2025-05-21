using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        
        int a = c;
        
        for(int i = 0; i < my_string.Length; i++) {
            if(i == a - 1){
                answer += my_string[i];
                a += m;
            }
                
                
        }
        
        return answer;
    }
}