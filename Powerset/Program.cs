using System;
using System.Collections.Generic;

namespace Powerset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 2, 3 };

            var powerSet = Powerset(array);

            foreach (var item in powerSet)
            {
                Console.WriteLine($"{String.Join<int>(',',item)}");
            }
            
        }

        public static List<List<int>> Powerset(List<int> array)
        {
            var result = new List<List<int>>();

            var set = 

            return result;
        }

        
    }
}
