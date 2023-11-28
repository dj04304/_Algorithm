        public class Solution
        {
            public int[] solution(int n, int m)
            {
                int[] answer = new int[2];
                int gcd = getGcd(n, m); // 최대공약수
                int lcm = n * m / gcd; // 최소공배수

                answer[0] = gcd;
                answer[1] = lcm;
               
                return answer;
            }

            private int getGcd(int n, int m)
            {
                if(n %  m == 0)
                {
                    return m;
                }
                else
                {
                    return getGcd(m, n % m);
                }
            }
        }