using System;

class Program
{
    static void Main(string[] args)
    {
        string[] arrays = Console.ReadLine().Split();

        int n = int.Parse(arrays[0]);
        int k = int.Parse(arrays[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
      
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int maxLength = 0;
        int start = 0;

        for(int i = 0; i < n; i++)
        {
            int num = a[i];

            if (dic.ContainsKey(num))
                dic[num]++;
            else
                dic[num] = 1;

            while (dic[num] > k)
            {
                int startNum = a[start];
                dic[startNum]--;
                start++;
            }

            maxLength = Math.Max(maxLength, i - start + 1);
        }

        Console.WriteLine(maxLength);
    }
}
