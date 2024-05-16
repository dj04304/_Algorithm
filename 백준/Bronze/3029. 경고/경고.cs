using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');
            string[] a = Console.ReadLine().Split(':');

            int H = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int S = int.Parse(input[2]);

            int TH = int.Parse(a[0]);
            int TM = int.Parse(a[1]);
            int TS = int.Parse(a[2]);

            if (TS < S)
            {
                TM--;
                TS += 60;
            }

            if (TM < M)
            {
                TH--;
                TM += 60;
            }

            if (TH < H)
            {
                TH += 24;

                if (TH == H)
                    if (M > TM)
                        TH += 24;
                    else if(M == TM)
                        if(S > TS)
                            TH += 24;
            }

            if(TH == H && TM == M && TS == S)
            {
                TH = 24;
                TM = 0;
                TS = 0;
            }
            else
            {
                TH -= H;
                TM -= M;
                TS -= S;
            }
            Console.WriteLine($"{TH:D2}:{TM:D2}:{TS:D2}");

        }
    }
}

