using System;

namespace Ingredients
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private readonly int baseCalories;
        private int weight;

        public Dough(int weight, string bakingTechnique, string flourType)
        {
            Weight = weight;
            Bakingtechnique = bakingTechnique;
            FlourType = flourType;
            baseCalories = 2;
        }

        public string FlourType
        {
            private get => flourType;
            set
            {
                switch (value.ToLower())
                {
                    case "white":
                        flourType = value.ToLower();
                        break;
                    case "wholegrain":
                        flourType = value.ToLower();
                        break;
                    default:
                        throw new Exception("Unknown flour type, try 'White' or 'Wholegrain'!");
                }
            }
        }

        public string Bakingtechnique
        {
            private get => bakingTechnique;
            set
            {
                switch (value.ToLower())
                {
                    case "chewy":
                        bakingTechnique = value.ToLower();
                        break;
                    case "crispy":
                        bakingTechnique = value.ToLower();
                        break;
                    default:
                        throw new Exception("Unknown baking technique, try 'Chewy' or 'Crispy'!");
                }
            }
        }

        public int Weight
        {
            private get => weight;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Weight can't be negative");
                }
                if (value <= 50)
                {
                    throw new Exception("Pizza can't be that small, try weighs above 50g!");
                }
                if (value > 400)
                {
                    throw new Exception("This Pizza seems too big, try something below 400g!");
                }

                weight = value;
            }
        }

        public double GetDoughCalories()
        {
            switch (flourType)
            {
                case "white" when Bakingtechnique == "chewy":
                    return Weight * baseCalories * 1.5 * 1.1;
                case "white" when Bakingtechnique == "crispy":
                    return Weight * baseCalories * 1.5 * 0.9;
                case "wholegrain" when Bakingtechnique == "chewy":
                    return Weight * baseCalories * 1.1;
                case "wholegrain" when Bakingtechnique == "crispy":
                    return Weight * baseCalories * 0.9;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
