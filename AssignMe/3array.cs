﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMe
{
    internal class _3array
    {
        static void Main()
        {
            int n;
            int[] array = new int[100];
            int[] newarray = new int[100];


            Console.WriteLine("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("List of negative numbers in the new array:");
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    newarray[i] = array[i];
                    Console.Write(newarray[i] + " ");
                }

            }
            Console.ReadLine();
        }
    }
}
    