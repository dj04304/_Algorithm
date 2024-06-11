using System;
using System.Text;

class Program
{
    static StringBuilder sb = new StringBuilder();

    static int n;
    static int m;

    static int[,] board;
    static bool[,] isVisited;

    // 좌, 우, 상, 하
    static int[] X = { -1, 1, 0, 0 };
    static int[] Y = {0, 0, -1, 1 };


    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        n = int.Parse(input[0]);
        m = int.Parse(input[1]);

        board = new int[n, m];
        isVisited = new bool[n, m];

        for (int i = 0; i < n;  i++)
        {
            string inputs = Console.ReadLine();
            for (int j = 0;j < m; j++)
            {
                board[i, j] = inputs[j] - '0';
            }

        }

        int result = BFS(0,0);

        Console.WriteLine(result);

    }

    private static int BFS(int startX, int startY)
    {
        // 좌측 이동시 + X[0] + Y[0]
        // 우측 이동시 + X[1] + Y[1]
        // 위로 이동시 +X[2] + Y[2]
        // 아래로 이동 시  + X[3] + Y[3]

        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((startX, startY, 1));
        isVisited[startX, startY] = true;
      
        while(queue.Count > 0)
        {
            var (x, y, distance) = queue.Dequeue();

            // 도착시에 그 값을 반환함
            if (x == n - 1 && y == m - 1)
                return distance;

            for(int i = 0; i < X.Length; i++)
            {
                int moveX = x + X[i];
                int moveY = y + Y[i];

                if(moveX >= 0 && moveY >= 0 && moveX < n && moveY < m)
                {

                    if (isVisited[moveX, moveY])
                        continue;

                    if (board[moveX, moveY] != 1)
                        continue;

                    isVisited[moveX, moveY] = true;
                    queue.Enqueue((moveX, moveY, distance + 1));
                }


            }


        }

        return -1;
    }
}
