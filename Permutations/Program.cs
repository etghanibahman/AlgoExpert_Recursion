using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 2 };

            Console.WriteLine($"Array :{ String.Join<int>(',', array)} ");

            var output = GetPermutations(array);
            foreach (var item in output)
            {
                Console.WriteLine($"Output is: {String.Join<int>(',', item)} ");
            }
        }

        #region Recursive swapping solution / O(N*N) space/time

        public static List<List<int>> GetPermutations(List<int> array)
        {
            var permutations = new List<List<int>>();
            if (array.Count > 0)
                PermutationsHelper(0, array, permutations);

            return permutations;
        }
        public static void PermutationsHelper(int i,List<int> array,List<List<int>> permutations)
        {
            if (i == array.Count - 1)
            {
                permutations.Add(new List<int>(array));
            }
            else
            {
                for (int j = i; j < array.Count; j++)
                {
                    Swap(i,j,array);
                    PermutationsHelper(i+1,array,permutations);
                    Swap(i,j,array);
                }
            }
        }

        public static void Swap(int i, int j, List<int> array)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        #endregion


        #region Simple Recursive
        //public static List<List<int>> GetPermutations(List<int> array)
        //{
        //    var permutation = GetAllPermutations(array);
        //    return permutation;
        //}

        //public static List<List<int>> GetAllPermutations(List<int> array)
        //{
        //    if (array.Count == 1)
        //        return new List<List<int>> { new List<int> { array[0] } };

        //    List<List<int>> otherPermutations = new List<List<int>>();

        //    for (int i = 0; i < array.Count; i++)
        //    {
        //        var otherElements = new List<int>(array);
        //        otherElements.RemoveAt(i);

        //        var allPremutations = GetAllPermutations(otherElements);
        //        foreach (var p in allPremutations)
        //        {
        //            var permutation = new List<int>(array.Count) { array[i] };
        //            permutation.AddRange(p);
        //            otherPermutations.Add(permutation);
        //        }
        //    }

        //    return otherPermutations;
        //}
        #endregion

    }
}
