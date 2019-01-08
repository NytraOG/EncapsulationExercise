using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Chicken's name can't be empty!");
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new Exception("Chicken's age must be between 0 and 15.");
                }
            }
        }

        public int EggsPerDay => CalculateProductionPerDay();

        private int CalculateProductionPerDay()
        {
            return 1;
        }
    }
}
