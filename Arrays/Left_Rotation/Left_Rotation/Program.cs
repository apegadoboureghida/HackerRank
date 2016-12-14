using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queryArgs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int[] temp = new int[queryArgs[1]];

            for (int i = 0; i < queryArgs[1]; i++)
            {
                temp[i] = array[i];
            }

            for (int i = queryArgs[1]; i<queryArgs[0]; i++)
            {
                array[i - queryArgs[1]] = array[i];
            }

            for(int i = queryArgs[0]- queryArgs[1]; i< queryArgs[0]; i++)
            {
                array[i] = temp[i-(queryArgs[0] - queryArgs[1])];
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
