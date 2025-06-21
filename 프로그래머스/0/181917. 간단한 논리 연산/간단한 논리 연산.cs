using System;

public class Solution {
         public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool answer = true;
        bool a = true;
        bool b = true;

        if (x1 || x2)
            a = true;
        else
            a = false;

        if (x3 || x4)
            b = true;
        else
            b = false;

        if (a && b)
            answer = true;
        else
            answer = false;

        return answer;
    }
}