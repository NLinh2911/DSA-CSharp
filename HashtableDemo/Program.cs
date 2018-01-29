using System;
using System.Collections;

namespace HashtableDemo {
    class Program {
        private static Hashtable employees = new Hashtable ();
        public static void Main () {
            // Add some values to the Hashtable, indexed by a string key
            employees.Add ("111-22-3333", "Scott");
            employees.Add ("222-33-4444", "Sam");
            employees.Add ("333-44-55555", "Jisun");
            // Hashtable is weakly typed -> not type safety -> it converts both keys and values to System.Object
            employees.Add(3339, "Not type safety");

            // Access a particular key
            if (employees.ContainsKey ("111-22-3333")) {
                string empName = (string) employees["111-22-3333"];
                Console.WriteLine ("Employee 111-22-3333's name is: " + empName);
            } else
                Console.WriteLine ("Employee 111-22-3333 is not in the hash table...");

            // Step through all items in the Hashtable
            // inserted order and order of the keys in the Keys collection are not necessarily the same
            foreach (var key in employees.Keys)
                Console.WriteLine ("Value at " + key + " = " + employees[key]);
        }
    }
}