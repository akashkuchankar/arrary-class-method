using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary_class_method
{
    internal class Class2
    {
        static void Main(string[] args)
        {  
            int[][] jarray = new int[3][];                 

            jarray[0] = new int[] { 10,45,33,56,78,98, };
            jarray[1] = new int[] { 10, 20, 30,34 };
            jarray[2] = new int[] { 100, 200 };

            for (int i = 0; i < jarray.Length; i++)          // this for row 
            {
                for (int j = 0; j < jarray[i].Length; j++)     // this for colom
                {
                    Console.Write(" "+ jarray[i][j]);          // space to separate element
                }
                Console.WriteLine();
            }

        }
    }
}
