using System;
using System.Text;

namespace Exercises {
    class Program {
        static void Main (string[] args) {
            // var a = new int[]{1, 3, 1, 1};
            // System.Console.WriteLine(Average(a));
            System.Console.WriteLine (Reversal ("abcad"));
            System.Console.WriteLine (Reversal ("a0b c1d"));
        }
        // ==== Average of numbers
        // Compute average of an integer array, rounded to closest integer or closest even integer when the fractional part is exactly .5.
        /*
        Input : [1,3,1,1]
        Output: 2
        Input : [-3,2]
        Output: 0
        Input : [-2,4,-1,6]
        Output: 2
         */
        public static int Average (int[] a) {
            decimal sum = 0;
            foreach (var item in a) {
                sum += item;
            }
            decimal avg = Math.Round ((decimal) (sum / a.Length), MidpointRounding.ToEven);
            return (int) avg;
        }
        // ==== Reverse Characters ====
        // Reverse all but first and last characters of a string.
        /*
        Input : "abcad"
        Output: "aacbd"

        Input : "a0b c1d"
        Output: "a1c b0d"
         */
        public static string Reversal (string s) {
            int len = s.Length;
            StringBuilder res = new StringBuilder (len);
            res.Append (s[0]);
            for (int i = len - 2; i >= 1; i--) {
                res.Append (s[i]);
            }
            // insert to a the specified index but if the stringbuilder actual value < its initialised length
            // and we insert value at an index greater than the actual value length -> ArgumentOutOfRangeException
            res.Insert (len - 1, s[len - 1]);
            return res.ToString ();
        }
        // ==== K-th Smallest ====
        /*
        Input : [2, 1, 4] and k = 3
        Output: 4
        Input : [7, 2, 1, 6, 1] and k = 3
        Output: 6
        */
        public static int Ksmallest (int[] a, int k) {
            Array.Sort (a);
            if (k >= a.Length)
                return a[a.Length - 1];
            return a[k];
        }
        // ==== Maximum Difference ====
        // Find maximum difference between 2 elements in an integer array. You may assume the array contains no less than two elements.
        /*
        Input : [3, 2, 9, 5]
        Output: 7
        Input : [1,1,1,1]
        Output: 0
         */
        public static int Difference (int[] a) {
            Array.Sort (a);
            return a[a.Length - 1] - a[0];
        }
        // ==== Depth of Nesting Parentheses
        /*
        Input : "a(())b()"
        Output: 2
        Input : "(()1()"
        Output: 0
         */
        public static int Parentheses (string s) {
            
        }
    }
}