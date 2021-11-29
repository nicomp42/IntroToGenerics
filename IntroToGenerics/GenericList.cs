/**************************************************
 * A simple example of using Generics in C#
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * (c) Bill Nicholson
 * ************************************************/
using System;
using System.Collections.Generic;

namespace IntroToGenerics {
    /// <summary>
    /// A demo of a class that supports Generics
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericList<T> {      // It's a Generic! 

        private List<T> myList;
        /// <summary>
        /// Constructor
        /// </summary>
        public GenericList() {      // Constructor! Doesn't need a T !
            myList = new List<T>();
        }
        /// <summary>
        /// Add an item to the object
        /// </summary>
        /// <param name="input">The item to be added</param>
        public void Add(T input) {
            myList.Add(input);
        }

//        override public String ToString() {
//            throw new Exception("Not implemented");
//        }

        /// <summary>
        /// Print the contents of the item
        /// </summary>
        public void Print() {
            foreach (T t in myList) {
                Console.WriteLine(t.ToString());        // Where is ToString() ?
            }
        }
        /// <summary>
        /// Sort the item using IComparable
        /// </summary>
        public void Sort() {
            myList.Sort();          // This works because... why, again? 
        }
    }
}
