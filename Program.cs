using System;

namespace Algo
{
    class Program
    {
        /// <summary>
        /// Testing changes
        /// Given sorted arrays sort them inplace 
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // input arrays needs to be sorted.
            int[] num = {1,2,3,4,5,6,7};
            int[] sum = { 2, 11, 32,55 };
            int[] gum = { 32, 56, 78 };
            int[] power = { 5, 6, 7, 89999 };

            //logic
            int[] result = SortIt(num, sum);
            result = SortIt(result, gum);
            result = SortIt(result, power);
            print(result);
        }
        a
        static void print(int [] result)
        {
            for (int p = 0; p < result.Length; p++)
            {
                Console.WriteLine(result[p]);
            }
        }

        /// <summary>
        /// Pick any two arrays and return result as a single sorted array
        /// </summary>
        /// <returns>int[] result containing sorted values</returns>
        /// <param name="num">Number.</param>
        /// <param name="sum">Sum.</param>
        static int[] SortIt(int [] num, int []sum)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int l1 = num.Length;
            int l2 = sum.Length;
            int[] result = new int[l1 + l2];
            while (j < l1 && k < l2)
            {
                if (num[j] < sum[k])
                {
                    result[i++] = num[j++];
                }
                else
                {
                    result[i++] = sum[k++];
                }
            }

            while (j < l1)
            {
                result[i] = num[j];
                i++;
                j++;
            }

            while (k < l2)
            {
                result[i] = sum[k];
                i++;
                k++;
            }
            return result;
        }
    }
}
