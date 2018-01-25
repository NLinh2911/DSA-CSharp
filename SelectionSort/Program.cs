using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an integer array that is not sorted
            System.Console.WriteLine("Enter arrays of numbers, separated by space");
            var input = Console.ReadLine().Trim();
            int[] arr = Array.ConvertAll(input.Split(" "), Convert.ToInt32);

            // Output the values of the array to the console
            Console.WriteLine ($"Array before sort: {input}");

            for (int i = 0; i < arr.Length; i++)
            {
                int newMinIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[newMinIndex]) {
                        newMinIndex = j;
                    }
                }
                var temp = arr[i];
                arr[i] = arr[newMinIndex];
                arr[newMinIndex] = temp;
            }
            Console.Write ("Array after sort: ");
            foreach (int val in arr) {
                Console.Write (val + " ");
            }
        }
    }
}
