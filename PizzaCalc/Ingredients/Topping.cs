using System;

namespace Ingredients
{
    public class Topping
    {
        private readonly int baseCalories;
        private int weight;
        private string type;

        public Topping(int weight, string type)
        {
            Weight = weight;
            Type = type;
            baseCalories = 2;
        }

        public int Weight
        {
            private get => weight;
            set
            {
                if (value <= 0)
                {
                    throw  new Exception("The topping's weight can't be zero or negative");
                }
                if (value > 50)
                {
                    throw new Exception("You might have too many toppings on your pizza, try something below 50g!");
                }

                weight = value;
            }
        }

        public string Type
        {
            private get => type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Topping type can't be empty!");
                }

                switch (value.ToLower())
                {
                    case "meat":
                    case "veggies":
                    case "cheese":
                    case "sauce":
                        type = value.ToLower();
                        break;
                    default:
                        throw new Exception($"Cannot place {value} on top of your pizza!");
                }
            }
        }

        public double GetToppingCalories()
        {
            switch (Type)
            {
                case "meat":
                    return Weight * baseCalories * 1.2;
                case "veggies":
                    return Weight * baseCalories * 0.8;
                case "cheese":
                    return Weight * baseCalories * 1.1;
                case "sauce":
                    return Weight * baseCalories * 0.9;
            }

            throw new NotImplementedException();
        }
    }
}
