//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace arrary_class_method
//{
//    internal class Class3
//    {
//        static void Main(string[] args)
//        {
//            string str1 = "Akash";
//            string str2 = " this is my name ";

//            Console.WriteLine(str1.Length);
//            Console.WriteLine(str2.Length);

//            // string str3=string.Concat(str1," ", str2);
//            string str3 = str1 + " " + str2;
//            Console.WriteLine(str3);

//            Console.WriteLine(str3.ToUpper());
//            Console.WriteLine(str3.ToLower());

//            char[] ch = str3.ToCharArray();
//            foreach (var item in ch)
//            {
//                Console.WriteLine(item);
//            }
//            bool res1 = str3.StartsWith("Akash");
//            bool res2 = str3.EndsWith("name");
//            Console.WriteLine(res1);
//            Console.WriteLine(res2);
//            str2.Trim();
//            str2.TrimStart();
//            str2.TrimEnd();
//        }
//    }
//}
