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
            int num = int.Parse(Console.ReadLine());
            string[] stustr = Console.ReadLine().Split(' ');
            int[] stu = Array.ConvertAll(stustr, int.Parse);
            string[] str = Console.ReadLine().Split(' ');
            int[] ndis = Array.ConvertAll(str, int.Parse);
            //洗牌算法main函数
            //int i=int.Parse(Console.ReadLine());
            //int[][] resultlist = new int[i][];
            //for (int j = 0; j < i; j++)
            //{
            //    string[] two = Console.ReadLine().Split(' ');
            //    int[] nk = Array.ConvertAll(two, int.Parse);
            //    int n = nk[0];
            //    int k = nk[1];
            //    string [] content = Console.ReadLine().Split(' ');
            //    int[] input = Array.ConvertAll(content, int.Parse);
            //    while (k != 0)
            //    {
            //        input = output(n, input);
            //        k--;
            //    }
            //    resultlist[j] = input;
            //}
            //for (int m = 0; m < i; m++)
            //{
            //    foreach (int j in resultlist[m])
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
        //洗牌算法
        //public static int[] output(int n,int [] input)
        //{
        //    int[] result = new int [2*n];
        //    for (int i = 0; i <2*n; i++)
        //    {
        //        if (i % 2 == 0)
        //            result[i] = input[2 * n - 1 - (i / 2)];
        //        else if (i % 2 != 0)
        //            result[i] = input[n - 1 - (i / 2)];
        //    }
        //    for (int m = 0; m < n; m++)
        //    {
        //        int tempt = result[m];
        //        result[m] = result[2 * n - m - 1];
        //        result[2 * n - m - 1] = tempt;
        //    }
                
        //    return result;
        //}
    }
}
