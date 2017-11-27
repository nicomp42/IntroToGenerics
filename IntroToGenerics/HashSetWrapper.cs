/**************************************************
 * A 'wrapper' class that inherits from HashSet
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToGenerics
{
    /// <summary>
    /// A wrapper class for a HashSet that handles ToString a little better
    /// </summary>
    /// <typeparam name="T">Some type</typeparam>
    class HashSetWrapper<T> : HashSet<T> {
        // Where is the ToString method that is being overridden?
        override public String ToString() {   
            String result = "";
            foreach (T t in this) {     // What is 'this' ?
                // Hmmm... we have a T, what to do with it?
                result += t.ToString(); // Guaranteed to work, kind-of.
            }
            return result;
        }
    }
}
