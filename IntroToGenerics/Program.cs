﻿/**************************************************
 * A simple example of using Generics in C#
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * ************************************************/
using System;
using System.Collections.Generic;

namespace IntroToGenerics {
    class Program {
        static void Main(string[] args) {
            DemonstrateOurGenericType();
            DemonstrateTheDictionary();
            DemonstrateHashSet();
        }
        /// <summary>
        /// Demonstrate cool things with Generics
        /// </summary>
        private static void DemonstrateOurGenericType() {
            GenericList<int> myIntList = new GenericList<int>();
            GenericList<String> myStringList = new GenericList<String>();

            // Add some integers to the integer type of our Generic
            myIntList.Add(42);
            myIntList.Add(43);
            myIntList.Add(44);
            myIntList.Add(45);
            myIntList.Add(1);
            myIntList.Add(-1);

            // Add some Strings to the String type of our Generic
            myStringList.Add("Fish");
            myStringList.Add("Cat");
            myStringList.Add("Aardvark");
            myStringList.Add("Borg");

            GenericList<Car> myCarList = new GenericList<Car>();        // This is OK... so far
            // Add some Car objects to our Car Generic
            myCarList.Add(new Car("Avanti"));
            myCarList.Add(new Car("Corvette"));
            myCarList.Add(new Car("Impala"));
            myCarList.Add(new Car("Cobalt"));
            myCarList.Add(new Car("Corvair"));
            myCarList.Add(new Car("Blazer"));

            // This works
            myIntList.Print();
            myStringList.Print();
            myCarList.Print();

            // This Works, almost
            myIntList.Sort();
            myStringList.Sort();
            //          myCarList.Sort();           // Uh Oh. This throws an exception.       You'll see

            // Print the sorted lists
            myIntList.Print();
            myStringList.Print();
            myCarList.Print();
        }
        /// <summary>
        /// C# has a cool data type called a Dictionary that supports generics. Actually, 2 generics
        /// </summary>
        private static void DemonstrateTheDictionary() {
            Dictionary<string, double> programmingLanguagesAndHourlyRates = new Dictionary<string, double>();       // Key/value pairs
            programmingLanguagesAndHourlyRates.Add("Javascript", 15.00);
            programmingLanguagesAndHourlyRates.Add("C", 50.00);
            programmingLanguagesAndHourlyRates.Add("C++", 60.00);
            programmingLanguagesAndHourlyRates.Add("Visual Basic", 14.00);
            programmingLanguagesAndHourlyRates.Add("php", 35.00);
            programmingLanguagesAndHourlyRates.Add("Kotlin", 100.00);
            programmingLanguagesAndHourlyRates.Add("C#", 45.00);
            // Look up an entry 'by key'
            double hourlyRate = programmingLanguagesAndHourlyRates["Kotlin"];
            Console.WriteLine("The hourly rate for Kotlin programmers is $" + hourlyRate);
            // Attempt to look up an entry that isn't there. An exception is thrown.
            // ToDo fix this exception
//            hourlyRate = programmingLanguagesAndHourlyRates["COBOL"];
//            Console.WriteLine("The hourly rate for Kotlin programmers is $" + hourlyRate);
        }
        /// <summary>
        /// Demonstrate the HashSet datatype
        /// </summary>
        private static void DemonstrateHashSet()
        {
            HashSet<String> myHashSet = new HashSet<String>();
            myHashSet.Add("Mushroom");
            myHashSet.Add("Pepperoni");
            myHashSet.Add("Green Olives");
            myHashSet.Add("Black Olives");
            myHashSet.Add("Anchovies");
            Console.WriteLine("HashSet = " + myHashSet.ToString()); // Yucky. Not what we want

            HashSetWrapper<String> myHashSetInWrapper = new HashSetWrapper<String>();
            myHashSetInWrapper.Add("Mushroom");
            myHashSetInWrapper.Add("Pepperoni");
            myHashSetInWrapper.Add("Green Olives");
            myHashSetInWrapper.Add("Black Olives");
            myHashSetInWrapper.Add("Anchovies");
            Console.WriteLine("HashSet = " + myHashSetInWrapper.ToString()); // Yucky. Not what we want
        }
    }
}

