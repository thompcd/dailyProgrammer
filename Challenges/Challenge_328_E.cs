using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public static class Challenge_328_E
    {
        public static int[,] main(int n, int[] genericArray)
        {
            //var squareArray = createSquareArrays(n, genericArray);

            try
            {
                return createSquareArrays(n, genericArray);
            }
            catch
            {
                return new int[,] { };
  
            }
            //// Loop over each dimension's length.
            //for (int i = 0; i < squareArray.GetLength(1); i++)
            //{
            //    for (int y = 0; y < squareArray.GetLength(0); y++)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

        }
        private static int[,] createSquareArrays(int n, int[] genericArray)
        {
            int index = 0;
            int[,] squareArray = new int[n,n];
            //load single dim array into 2 dim array
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    squareArray[x, y] = genericArray[index];
                    index++;                }
            }
            //int index = 0;
            //int sqrt = (int)Math.Sqrt(array.Length);
            //int[,] multi = new int[sqrt, sqrt];
            //for (int y = 0; y < sqrt; y++)
            //{
            //    for (int x = 0; x < sqrt; x++)
            //    {
            //        multi[x, y] = array[index];
            //        index++;
            //    }
            //}
            //return multi;
            return squareArray;
        }
    }
}
