using System;
using System.Linq;

namespace _05_Pizza_Calories
{
   public class Dough
    {
        private string flourType;//white or wholegrain
        private string bakingTechnique;//crispy, chewy or homemade
        private int weight;
        private string[] allowedTypes = { "white", "wholegrain" };
        private string[] allowedTechniques = { "crispy", "chewy","homemade" };

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.weight = weight;
        }

        private string FlourType
        {
            set
            {
                if (allowedTypes.Contains(value.ToLower()))
                {
                    this.flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (allowedTechniques.Contains(value.ToLower()))
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");//Invalid baking technique.
                }
            }



        }

        private int Weight
        {
            set
            {
                if (value<0||value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        public float GetCalories()
        {
            float coef = 1.0f;
            if (this.flourType.ToLower() == "white") coef *= 1.5f;
            if (this.bakingTechnique.ToLower() == "crispy") coef *= 0.9f;
            if (this.bakingTechnique.ToLower() == "chewy") coef *= 1.1f;
            return 2 * weight * coef;
        }
    }
}