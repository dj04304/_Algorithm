using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int index = (k - 1) * 2 % numbers.Length;
    return numbers[index];
    }
}