using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Challenge_321_E//static void Main(string[] args)
        //Challenge_321_E//{
        //Challenge_321_E//    Console.WriteLine(Challenges.Challenge_321_E.main(DateTime.Now));
        //Challenge_321_E//}
        static void Main(string[] args)
        {
            var squareArray = Challenges.Challenge_328_E.main
                (5, 
                new int[] {1, 2, 3, 4, 5, 5, 1, 2, 3, 4, 4, 5, 1, 2, 3, 3, 4, 5, 1, 2, 2, 3, 4, 5, 1 });

            //print answer as a pretty matrix
            int rowLength = squareArray.GetLength(0);
            int colLength = squareArray.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", squareArray[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
