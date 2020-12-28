using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechType, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechType;
            this.Weight = weight;
        }

        public string FlourType
        {
            get 
            { 
                return flourType;
            }
            set
            {
                if (!DoughValidator.IsValidFlourType(value))
                {
                    throw new Exception("Invalid type of dough!");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            { 
                return bakingTechnique;
            }
            set
            {
                if (!DoughValidator.IsValidBakingTechnique(value))
                {
                    throw new Exception("Invalid type of dough!");
                }

                bakingTechnique = value;
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
                if(value < 1 || value > 200)
                {
                    throw new Exception("Dough weght should be in range [1..200].");
                }

                weight = value;
            }
        }

        public double GetTotalCalories()
        {
            return this.Weight
                * 2
                * DoughValidator.GetFlourModifier(this.FlourType)
                * DoughValidator.GetBakingTechniqueModifier(this.BakingTechnique);
        }
    }
}
