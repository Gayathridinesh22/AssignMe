using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMe
{
    internal class _3string
    {
        static void Main()
        {
            bool n;
            string str1, str2;
            Console.WriteLine("Enter the string:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            str2 = Console.ReadLine();
            n = str1.Contains(str2);
            if (n)
            {
                Console.WriteLine("The substring is present in the string");
            }
            else
            {
                Console.WriteLine("The substring is not present in the string");
            }
            Console.ReadLine();
        }
    }
}
