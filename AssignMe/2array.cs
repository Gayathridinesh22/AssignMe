using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMe
{
    internal class _2array
    {
        static void Main()
        {

            int n, sum = 0;
            int[] array = new int[100];

            Console.WriteLine("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of the array elements is:" + sum);
            Console.ReadLine();

        }
    }
}
    

