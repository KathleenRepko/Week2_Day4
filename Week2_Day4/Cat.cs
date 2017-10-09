using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4 //Intro to OOP
{
    class Cat
    {
        //STATES
        //Fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true; //in Fields we may set the value

        //Properties - like Mama Bear (can't get to Baby Bear except through Mama Bear)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        //BEHAVIORS

        //Constructors - type of method which allows us to create an object
        public Cat() //no parameters in default
        {
            //"default constructor" because it takes no parameters in the parentheses
            //Body MAY have information, e.g. this.name = name;
            //Must have default constructor in order to create other constructors.
        }

        public Cat(string name, int age, string furColor) //overloaded constructor - create constructor of same name, but assign values
        {
            this.name = name;   // keyword |this| is a pointer
            this.age = age;
            this.furColor = furColor;
        }

        //Methods

        public void Eat()
        {
            if(isHungry == true)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }





    }
}
