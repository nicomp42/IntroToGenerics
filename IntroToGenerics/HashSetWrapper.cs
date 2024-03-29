﻿/**************************************************
 * A 'wrapper' class that inherits from HashSet.
 * The wrapper adds a better implementation of ToString()
 *  because the inherited version of ToString is useless for us.
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * (c) Bill Nicholson
 * ************************************************/
using System;
using System.Collections.Generic;

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
