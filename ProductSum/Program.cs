using System;
using System.Collections.Generic;

namespace ProductSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> array = new List<object> { 5,2, new List<object>{ 7, -1 }
                          ,3, new List<object> { 6, new List<object> { -13,8},4 } };

            Console.WriteLine($"The output is : {ProductSum(array)}");
            Console.ReadKey();
        }

        public static int ProductSum(List<object> array)
        {
            if (array.Count < 1)
            {
                return 0;
            }
            return CalculateSum(array,1);
        }

        public static int CalculateSum(List<object> array, int depth)
        {
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].GetType().IsValueType && array[i] is int)
                {
                    sum += int.Parse(array[i].ToString());
                }
                else
                {
                    sum += CalculateSum(array[i] as List<object>, depth + 1);
                }
            }

            return sum * depth;
        }
    }
}
