using System;
using System.Text;

class Program
{
    //입력 값
    static int n;

    // 보드와 방문 여부
    static int[,] apart;
    static bool[,] isVisited;

    static List<int> list = new List<int>();

    // 상, 하, 좌, 우
    static int[] X = { -1, 1, 0, 0 };
    static int[] Y = {0, 0, -1, 1 };


    static void Main(string[] args)
    {

        n = int.Parse(Console.ReadLine());
        apart = new int[n, n];
        isVisited = new bool[n, n];

        for (int i = 0; i < n;  i++)
        {
            string inputs = Console.ReadLine();

            for (int j = 0;j < n; j++)
            {
                // '0'을 빼서 int값으로 변환시킴
                apart[i, j] = inputs[j] - '0';
            }

        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (apart[i, j] == 1 && !isVisited[i, j])
                {
                    int size = DFS(i, j);
                    list.Add(size);
                }
            }
        }

        list.Sort();
        Console.WriteLine(list.Count);
        
        foreach(int a in list)
        {
            Console.WriteLine(a);
        }

    }

    private static int DFS(int startX, int startY)
    {
        // 상, 하, 좌, 우
        // 위로 이동시 + X[0] + Y[0]
        // 아래 이동시 + X[1] + Y[1]
        // 좌측 이동시 +X[2] + Y[2]
        // 우측 이동 시  + X[3] + Y[3]

        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((startX, startY));
        isVisited[startX, startY] = true;

        int count = 0;

        while(stack.Count > 0)
        {
            var(sx, sy) = stack.Pop();
            count++;

            for (int i = 0; i < X.Length; i++)
            {
                int moveX = X[i] + sx;
                int moveY = Y[i] + sy;

                if(moveX >= 0 && moveY >= 0 && moveX < n && moveY < n)
                {
                    if (isVisited[moveX, moveY])
                        continue;

                    if (apart[moveX, moveY] == 0)
                        continue;

                    isVisited[moveX, moveY] = true;
                    stack.Push((moveX, moveY));

                }

            }
        }
      
       

        return count;
    }
}
