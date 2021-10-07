using System;

namespace Smallest_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variable to hold the result
            int result = 1;

            //Start for loop at 2 then iterate through 20 
            for(int i = 2; i <= 20; i++)
            {
                //Pass in iterator as a, and result as b
                result = LCM(i, result);
            }
            //Print to Console
            Console.WriteLine("Smallest multiple: " + result);
        }
        //Find Lowest common denominator
        static int LCM(int a, int b)
        {
            //Multiple both the iterator 
            return a * b / HCF(a, b);
        }
        static int HCF(int a, int b)
        {
            if( b == 0)
            {
                return a;
            }
            else
            {
                return HCF(b, a % b);
            }
        }
        //Solution found on 
        //https://www.youtube.com/watch?v=6VEmOvXcvRg
    }
}
