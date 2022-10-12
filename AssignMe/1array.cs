using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMe
{
    internal class _1array
    {
        static void Main()
        {
            int counteven = 0;
            int countodd = 0;
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    counteven = counteven + 1;
                }
                else
                {
                    countodd = countodd + 1;
                }
            }
            Console.WriteLine("The Count of even elements in the array is:" + counteven);
            Console.WriteLine("The Count of odd elements in the array is:" + countodd);
            Console.ReadLine();


        }
    }
}

    

