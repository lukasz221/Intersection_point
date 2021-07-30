using System;
using System.Collections.Generic;

namespace Intersection_point
{
    class Program
    {
        public static List<int> a = new List<int>();
        public static List<int> b = new List<int>();


        static void Main(string[] args)
        {
            FillList();

            Console.WriteLine(Point().ToString());

            Console.ReadKey();
        }

        public static int Point()
        {
            bool check = false;

            foreach (var item in a)
            {
                check = b.Contains(item);
                if (check)
                {
                    return item;
                }
            }

            return 0;
        }

        public static void FillList()
        {
            a.Add(3);
            a.Add(7);
            a.Add(8);
            a.Add(10);

            b.Add(99);
            b.Add(1);
            b.Add(8);
            b.Add(10);
        }
    }
}
