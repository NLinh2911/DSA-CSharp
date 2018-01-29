using System;

namespace EnumDemo {
    class Program {
        // constants are stored and separated
        public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main (string[] args) {
            int x = (int) Days.Sunday;
            int y = (int) Days.Friday;
            System.Console.WriteLine ("Sun = {0}", x);
            System.Console.WriteLine ("Fri = {0}", y);
            Console.WriteLine (Enum.GetName (typeof (Days), 4));

            Console.WriteLine ("Days constant names:");

            foreach (string str in Enum.GetNames (typeof (Days)))
            {
                Console.WriteLine (str);
            }
        }
    }
}