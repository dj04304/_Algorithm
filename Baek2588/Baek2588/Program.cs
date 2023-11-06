namespace Baek2588
{
    //int num1 =  B -( (B / 10) * 10 );
    //int num2 = (B - (B / 100) * 100) / 10;
    //int num3 = B / 100;
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine(A * (B % 10) );
            Console.WriteLine(A * ((B % 100) / 10) );
            Console.WriteLine(A * (B / 100));
            Console.WriteLine(A * B);


        }
    }
}