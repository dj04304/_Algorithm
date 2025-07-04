public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        if(s.Length != 4 && s.Length != 6)
            return false;
            
        foreach(char c in s){
            if(!char.IsDigit(c))
                return false;
        }
        
        return answer;
    }
}