using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Animal
    {
        // member variables (attributes)
        private string type;
        private double weight;
        private string color;

        // properties
        public string Type
        {
            get
            {
                return type;
            }
            
            set
            {
                type = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        // instance methods
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise");
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }
}