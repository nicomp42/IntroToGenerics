/**************************************************
 * A simple example of using Generics in C#
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToGenerics {
    class Program {
        static void Main(string[] args) {

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
    }
}
