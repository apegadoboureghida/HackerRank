using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] args_input = Console.ReadLine().Split(' ');
        int N = int.Parse(args_input[0]);
        int Q = int.Parse(args_input[1]);
        //Creating the seqList.
        int[][] seqList = new int[N][];

        int lastAns = 0;

        for (int i = 0; i < Q; i++)
        {
            int[] queryArgs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int y = queryArgs[2];
            int x = queryArgs[1];
            int queue = queryArgs[0];
            int seqListIndex = (x ^ lastAns) % N;

            //Query 1
            if (queue == 1)
            {
                if (seqList[seqListIndex] == null) {
                    seqList[seqListIndex] = new int[1];
                    seqList[seqListIndex][0] = y;
                }else if(seqList[seqListIndex].Length < N)
                {
                    int[] temp = new int[seqList[seqListIndex].Length + 1];
                    seqList[seqListIndex].CopyTo(temp, 0);
                    temp[temp.Length - 1] = y;
                    seqList[seqListIndex] = temp;
                }
                //Query 2
            }
            else
            {
                int pos = y % seqList[seqListIndex].Length;
                lastAns = seqList[seqListIndex][pos];

                //Print lastAns
                Console.WriteLine(lastAns);
            }
        }
    }
}