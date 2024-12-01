using System;

public class Solution
{
    public int solution(string word)
    {
        string vowel = "AEIOU";
        int[] weights = { 781, 156, 31, 6, 1 }; 

        int index = 0;

        for (int i = 0; i < word.Length; i++)
        {
            int charIndex = vowel.IndexOf(word[i]);
            index += charIndex * weights[i] + 1;
        }

        return index;
    }
}
