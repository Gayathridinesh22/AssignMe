using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMe
{
    internal class _1string
    {
        static void Main()
        {
            int i = 0, count = 1;
            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();

            while(i<=str.Length-1)
            {
                if(str[i] ==' '  || str[i]=='\n' || str[i]=='\t' )

                {
                    count = count + 1;
                }
                i++;
            }
            Console.WriteLine("Total number of words in the string:" + count);
            Console.ReadLine();
        }
    }
}
