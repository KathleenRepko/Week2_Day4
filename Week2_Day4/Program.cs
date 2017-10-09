using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mittens = new Cat();

            mittens.Name = "Mittens";

            Cat secondCat = new Cat("Oz", 3, "orange and white");

            Console.WriteLine(mittens.Name);
            Console.WriteLine(secondCat.Name);

            mittens.Eat();

            mittens.WorkOut();


        }
    }
}
