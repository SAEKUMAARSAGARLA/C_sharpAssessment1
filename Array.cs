/*3Q write a program to accept param array that method should find sum of all integers and display result
 * write a client program to call method*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharpAssessment1
{
    internal class Array
    {
        static int sum(int[] arr, int n)// params and method 
        {

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static void Main()
        {
            int[] arr = { 10, 27, 11, 19, 97,99 };
            int n = arr.Length;

            Console.WriteLine("Sum of array value is " + sum(arr, n));// calling method
        }
    }
}
