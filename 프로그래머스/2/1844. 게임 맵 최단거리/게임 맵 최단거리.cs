using System;
using System.Collections.Generic;

class Solution {
     public int solution(int[,] maps)
 {
     int targetX = maps.GetLength(0);
     int targetY = maps.GetLength(1);

     Queue<(int x, int y, int distance)> queue = new Queue<(int x, int y, int distance)>();
     queue.Enqueue((0, 0, 1));

     bool[,] visited = new bool[targetX, targetY];

     visited[0, 0] = true;

     int[,] directions = 
     { 
         { 0, 1 }, 
         { 1, 0 }, 
         { 0, -1 }, 
         { -1, 0 } 
     };

     while (queue.Count > 0) 
     {
         var(x, y, dist) = queue.Dequeue();

         if (x == targetX - 1 && y == targetY - 1)
             return dist;

        for(int i = 0; i < directions.GetLength(0); i++)
         {
             int nx = x + directions[i, 0];
             int ny = y + directions[i, 1];

             if(nx >= 0 && ny >= 0 && nx < targetX && ny < targetY && maps[nx, ny] == 1 && !visited[nx, ny])
             {
                 visited[nx, ny] = true;
                 queue.Enqueue((nx, ny, dist + 1));
             }

         }
     }

     return -1;
 }
}