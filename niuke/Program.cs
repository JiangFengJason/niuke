using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niuke
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=int.Parse(Console.ReadLine());
            int[][] resultlist = new int[i][];
            for (int j = 0; j < i; j++)
            {
                string[] two = Console.ReadLine().Split(' ');
                int[] nk = Array.ConvertAll(two, int.Parse);
                int n = nk[0];
                int k = nk[1];
                string [] content = Console.ReadLine().Split(' ');
                int[] input = Array.ConvertAll(content, int.Parse);
                while (k != 0)
                {
                    input = output(n, input);
                    k--;
                }
                resultlist[j] = input;
            }
            for (int m = 0; m < i; m++)
            {
                foreach (int j in resultlist[m])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[] output(int n,int [] input)
        {
            int[] result = new int [2*n];
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < 2; j++)
                    result[i + j] = input[ 2*n -n*j - i - 1];
                result[i]=
            }
            for (int m = 0; m < 2 * n; m++)
                result[m] = result[2 * n - m - 1];
            return result;
        }
    }
}
