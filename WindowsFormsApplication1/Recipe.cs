using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Recipe
    {
        private string[] ingredientArray;
        private string foodName;
        private string description;
        private string foodCategory;
      
        private int i = 0;


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="maxNumOfIngredient"></param>
        public Recipe(int maxNumOfIngredient)
        {
            ingredientArray = new string[maxNumOfIngredient];
            DefaultValues();
        }

        /// <summary>
        /// set all default values
        /// </summary>
        public void DefaultValues()
        {
            for(int index = 0; index < ingredientArray.Length; index++)
                ingredientArray[index] = string.Empty;

            foodName = string.Empty;
            description = string.Empty;
            foodCategory = string.Empty;
        }

        /// <summary>
        /// find current number of ingredient
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumOfIngredient()
        {
            int count = 0;

            for(int index = 0; index < ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                    count++;
            }

            return count;
        }

        /// <summary>
        /// to return max ingredients number
        /// </summary>
        public int MaxNumOfIngredients
        {
            get { return this.ingredientArray.Length; }
        }

        /// <summary>
        /// for string modification purpose
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string discriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(discriptionText))
                discriptionText = "No Discription";

            return discriptionText;
        }


        /// <summary>
        /// change ingredient at a particular position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ChangeIngredientAt(int index, string value)
        {
            bool bok = true;

            if (index >= 0 && index < GetCurrentNumOfIngredient())
                ingredientArray[index] = value;
            else
                bok = false;

            return bok;
        }


        /// <summary>
        /// get set category
        /// </summary>
        public string category
        {
            get { return this.foodCategory; }
            set { this.foodCategory = value; }
        }

        public int number
        {
            get { return this.i; }
            set { this.i = value; }
        }

        /// <summary>
        /// get set description
        /// </summary>
        public string des
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// get set ingredient
        /// </summary>
        public string[] ingredient
        {
            get { return this.ingredientArray; }
            set { this.ingredientArray = value; }
        }

        /// <summary>
        /// get set name
        /// </summary>
        public string name
        {
            get { return this.foodName; }
            set { this.foodName = value; }
        }        
    }
}