using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1,2,3,4,4,6,2,6,7,8 };
            int[] array2 = new int[] { 2,4,6,2,5,7,9,4,2,7 };

            var query1 = (from i in array1 select i).Union(from j in array2 select j);
            Console.WriteLine("Union");
            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");

            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);
            Console.WriteLine("Intersect");
            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");

            var query3 = (from i in array1 select i).Except(from j in array2 select j);
            Console.WriteLine("Except");
            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");

            var query4 = (from i in array1 select i).Concat(from j in array2 select j);
            Console.WriteLine("Concat");
            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("-----------------------");

            Console.WriteLine("Aggregate Functions:-");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Sum:-");

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();

            Console.WriteLine("Total Sum of two arrays:-" + (sum1 + sum2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Max:-");

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();

            Console.WriteLine("Maximum number in both arrays:- \nMax in first array: "+(max1)+ "\nMax in Second array:" + (max2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Min:-");

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();

            Console.WriteLine("Minimum number in both arrays:- \nMin in first array: " + (min1)+ "\nMin in Second array: " + (min2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Average:-");

            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();

            Console.WriteLine("Average of arrays:- \nAvg in first array: "+ (avg1) + "\nMin in Second array: " + (avg2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Count:-");

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();

            Console.WriteLine("Total number of elements in arrays:- \nElement in first array: " +(count1) + "\nMin in Second array: " + (count2));

            Console.WriteLine("-----------------------");

            var query33 = (from i in array1 select i).Distinct();
            Console.WriteLine("Distinct element in array1 ");
            foreach (int i in query33)
            {
                
                Console.WriteLine( i );
            }

            Console.WriteLine("-----------------------");

            var query34 = (from i in array2 select i).Distinct();
            Console.WriteLine("Distinct element in array2 ");
            foreach (int i in query34)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}
