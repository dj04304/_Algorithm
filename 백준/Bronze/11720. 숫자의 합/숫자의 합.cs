   internal class Program
   {
       static void Main(string[] args)
       {

           int count = int.Parse(Console.ReadLine());
           string input = Console.ReadLine();

           int result = 0;

           for(int i = 0;  i < count; i++)
           {
               result += int.Parse(input[i].ToString());
           }

           Console.WriteLine(result);

       }

   }