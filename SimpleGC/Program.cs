using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GC basic");

            //create a new car object on the managed heap.
            //we are returned a reference to this object
            //("refToMyCar").
            Car refToMyCar = new Car("Tiger Head",70);

            //the c# (.) operator is used to invoke members on the object
            //using our reference variable
            Console.WriteLine(refToMyCar.ToString());

            //print out the generation of the refToMyCar
            Console.WriteLine("Generation of the refToMyCar is {0}",GC.GetGeneration(refToMyCar));
            //print out the total generation
            Console.WriteLine("this os has {0} object generation",GC.MaxGeneration+1);

            //prints out the estimated number of byte on heap
            Console.WriteLine("Estimated byte on heap: {0}",GC.GetTotalMemory(false));
            Console.ReadLine();

        }
    }
}
