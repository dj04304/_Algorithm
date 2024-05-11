using System.Text;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string s = "END";

            while (true)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();

                if(input == s)
                    break;
                Array.Reverse(chars);
                Console.WriteLine(chars);
            }


        } 
    }
}

