using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken1 = new Chicken("Erna", 12);

            Console.WriteLine($"{chicken1.Name} is {chicken1.Age} years old and poops out {chicken1.EggsPerDay} eggs per day");
        }
    }
}
