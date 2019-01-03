using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Dog : Animal
    {
        // member variables
        private string breed;

        // properties
        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }

        // instance methods
        public void WagTail()
        {
           Console.WriteLine("Dog wags tail"); 
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }
    }
}