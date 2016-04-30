using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RecipeManager
    {
        public Recipe[] foodList;
        int i;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="maxNumOfElements"></param>
        public RecipeManager(int maxNumOfElements)
        {
            foodList = new Recipe[maxNumOfElements];
        }

        /// <summary>
        /// finding empty index
        /// </summary>
        /// <returns></returns>
        private int FindVacentPlace()
        {
            for(int index = 0; index < foodList.Length; index++)
            {
                if (foodList[index] == null)
                    return index;
            }

            return -1;
        }

        /// <summary>
        /// it will return recipe of a particular index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Recipe GetRecipeAt(int index)
        {
            if (index >= 0 && index < foodList.Length)
                return foodList[index];

            return null;
        }

        /// <summary>
        /// for adding new recipe
        /// </summary>
        /// <param name="name"></param>
        /// <param name="catagory"></param>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        public bool Add(string name, string catagory, string[] ingredient)
        {
            bool bok = false;
            int index = FindVacentPlace();
            if(index >= 0)
            {
                Recipe recipe = new Recipe(ingredient.Length);
                recipe.name = name;
                recipe.ingredient = ingredient;
                recipe.category = category;

                foodList[index] = recipe;
                bok = true;
            }

            return bok;
        }

        /// <summary>
        /// it will return current number of recipe
        /// </summary>
        /// <returns></returns>
        public int CurrentNumOfItems()
        {
            int count = 0;

            for(int index = 0; index < foodList.Length; index++)
            {
                if (foodList[index] != null)
                    count++;
            }

            return count;
        }

        public Boolean add(Recipe newRecipe)
        {
            if (i < 10)
            {
                foodList[i] = newRecipe;
                i++;
                return true;
            }
            else
                return false;
        }

        public int numberOfItems
        {
            get { return foodList.Length; }
        }

        public string category { get; set; }
    }
}