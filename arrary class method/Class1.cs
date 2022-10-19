using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary_class_method
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 56, 12, 89, 22 };
           
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("sorted array");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("reverse arrary");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            } 
        }
    }
}
