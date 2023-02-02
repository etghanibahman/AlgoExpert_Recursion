using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine($"{String.Join<int>(',', item)}");
            }

        }

        public static List<List<int>> Powerset(List<int> array)
        {
            List<List<int>> result = new List<List<int>>() { new List<int>()};
            PowersetHelper(array, result, new List<int>());

            return result;
        }


        public static void PowersetHelper(List<int> array,
            List<List<int>> result, List<int> powerSets,  int index = 0)
        {
            if (index == array.Count)
            {
                return;
            }

            for (int j = index; j < array.Count; j++)
            {
                List<int> newSets = new List<int>(powerSets);
                newSets.Add(array[j]);
                result.Add(newSets);
                PowersetHelper(array,result,newSets, j + 1);
            }
        }

        //public static List<List<int>> PowersetHelper(List<int> array, int index = int.MinValue)
        //{
        //    if (index == int.MinValue)
        //        index = array.Count - 1;
        //    else if (true)
        //        return new List<List<int>>();

        //    var ele = array[index];
        //    var subsets = PowersetHelper(array, index - 1);

        //    for (int i = 0; i < subsets.Count; i++)
        //    {
        //        var currentSubset = subsets[i];
        //        subsets.Add(currentSubset.Concat(new List<int> { ele }).ToList());
        //    }


        //    return subsets;
        //}

    }
}
