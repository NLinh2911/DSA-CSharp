using System;

namespace InsertionSort {
    class Program {
        static void Main (string[] args) {
            // Declare an integer array that is not sorted
            System.Console.WriteLine("Enter arrays of numbers, separated by space");
            var input = Console.ReadLine().Trim();
            int[] arr = Array.ConvertAll(input.Split(" "), Convert.ToInt32);

            // Output the values of the array to the console
            Console.WriteLine ($"Array before sort: {input}");

            // loop through the array
            for (int i = 1; i < arr.Length; i++) {
                int newValue = arr[i];
                // loop through the element from arr[i] to the beginning
                for (int j = i; j >= 0; j--) {
                    // if the preceeding value is greater than the curent value
                    if (arr[j] > newValue) {
                        // swap value
                        var temp = arr[j];
                        arr[j] = newValue;
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write ("Array after sort: ");
            foreach (int val in arr) {
                Console.Write (val + " ");
            }
        }
    }
}