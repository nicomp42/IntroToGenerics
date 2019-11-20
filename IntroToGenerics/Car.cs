/**************************************************
 * A simple example of using Generics in C#
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * (c) Bill Nicholson
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToGenerics {
    /// <summary>
    /// We will use this class to implement an instance of our GenericList<T> class  />
    /// </summary>
    class Car {
        /// <summary>
        /// Model of the Car
        /// </summary>
        public String model {get; set;}
        /// <summary>
        /// Constructor
        /// </summary>
        public Car() {

        }
        /// <summary>
        /// Constructor with one argument
        /// </summary>
        /// <param name="model">The model of the Car</param>
        public Car(String model) {
            this.model = model;     // Scope! Do you get it?
        }

    }
}
