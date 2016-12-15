using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //Creating stringN
            inputValue[] stringN = new inputValue[20];

            for (int i = 0; i < N; i++)
            {
                string temp = Console.ReadLine();
                if (stringN[temp.Length - 1] == null)
                {
                    stringN[temp.Length - 1] = new inputValue(temp);
                }
                else
                {
                    inputValue value = stringN[temp.Length - 1];
                    while (value.next != null)
                    {
                        value = value.next;
                    }
                    value.next = new inputValue(temp);
                }
            }

            int Q = int.Parse(Console.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                string temp = Console.ReadLine();

                int result = 0;
                if (stringN[temp.Length - 1] != null)
                {
                    inputValue value = stringN[temp.Length - 1];
                    while (value.next != null)
                    {
                        if (value.value == temp) result++;
                        value = value.next;
                    }
                    if (value.value == temp) result++;
                }
                Console.WriteLine(result);
            }
        }
    }
    class inputValue
    {
        public String value
        {
            get;
        }
        public inputValue next
        {
            get; set;
        }
        public inputValue(String value)
        {
            this.value = value;
        }

    }
}
