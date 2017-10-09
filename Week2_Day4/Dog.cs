using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Dog
    {
        //fields
        private string furLength;
        private float height;
        private string runningSpeed;
        private double weight;

        //Properties
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Constructors
        public Dog()
        {
            
        }

        //overloaded Constructor
        public Dog(string furLength, float height)
        {
            this.furLength = furLength;
            this.height = height;
        }

        //Methods

        public void Run()
        {
            runningSpeed = "getting faster.";
            weight--;
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight -= 0.1; 
        }

        public void Groom()
        {
            furLength = "all cleaned up";
        }

    }
}
