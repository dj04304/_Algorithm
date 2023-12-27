public class Solution
{
    public string solution(int a, int b)
    {
        /// 요일이 같은 날짜의 차이는 7일
        /// 2016년은 윤년 (2월은 29일)
        /// 31 29 31 30 31 30 31 31 30 31 30 31
        /// 금요일이 기준점
        /// 

        string[] day = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

        int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int temp = 0;

        for(int i = 0; i < a -1; i++)
        {
            temp += month[i]; // 전 달까지 다 더한 값
        }

        temp += b -1;



        string answer = day[temp % 7];
        return answer;
    }
}