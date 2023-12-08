using System; 
public class Solution
        {
            static string str = "";
            static string chageNum = "";

            public int solution(string s)
            {

                int answer = 0;
                int a;

                for (int i = 0;  i < s.Length; i++)
                {
                    char c = s[i];

                    if (int.TryParse(c.ToString(), out a))
                    {
                        str += s[i];
                    }
                    else
                    {
                        chageNum += s[i];
                        ReplaceNum();
                    }
                }

                bool checkNum = int.TryParse(str, out a);

                if(checkNum)
                {
                    answer = a;
                }

                return answer;
            }
            void ReplaceNum()
            {
                switch (chageNum)
                {
                    case "zero":
                        str += "0";
                        chageNum = "";
                        break;
                    case "one":
                        str += "1";
                        chageNum = "";
                        break;
                    case "two":
                        str += "2";
                        chageNum = "";
                        break;
                    case "three":
                        str += "3";
                        chageNum = "";
                        break;
                    case "four":
                        str += "4";
                        chageNum = "";
                        break;
                    case "five":
                        str += "5";
                        chageNum = "";
                        break;
                    case "six":
                        str += "6";
                        chageNum = "";
                        break;
                    case "seven":
                        str += "7";
                        chageNum = "";
                        break;
                    case "eight":
                        str += "8";
                        chageNum = "";
                        break;
                    case "nine":
                        str += "9";
                        chageNum = "";
                        break;
                }
            }
        }