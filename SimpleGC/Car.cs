using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Car
    {
        public string PetName { get; set; }
        //the state of the car
        public int CurrentSpeed { get; set; }
        //a default custom constructor
        public Car()
        { }

        //here the caller is allowed to set the full state of the Car
        public Car(string pn,int cs)
        {
            PetName = pn;
            CurrentSpeed = cs;
        }
        public override string ToString() => $"{PetName} is going {CurrentSpeed}";

        
    }

}
