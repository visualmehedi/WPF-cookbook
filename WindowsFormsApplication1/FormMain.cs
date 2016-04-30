using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        private Recipe curRecipe;
        private RecipeManager manager;
        private const int numOfIng = 20;
        private const int numOfIte = 20;


        /// <summary>
        /// constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            curRecipe = new Recipe(numOfIng);
            manager = new RecipeManager(numOfIte);
            IntializeGUI();
        }

        /// <summary>
        /// GUI initialization
        /// </summary>
        private void IntializeGUI()
        {
            comboBox.Items.Add(FoodCategory.PrType.Fish.ToString());
            comboBox.Items.Add(FoodCategory.PrType.Meat.ToString());
            comboBox.Items.Add(FoodCategory.PrType.SeaFood.ToString());
            comboBox.Items.Add(FoodCategory.PrType.Vegeterian.ToString());
            comboBox.SelectedIndex = 0;
            listBox.Items.Clear();
            listBox.Update();
            listBox.Refresh();
        }

        /// <summary>
        /// add ingredients button click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIng_Click(object sender, EventArgs e)
        {
            FormIngredients dlg = new FormIngredients();
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
                if (dlg.number < 1)
                    MessageBox.Show("No ingredients specified!");
                else
                {
                    curRecipe.ingredient = dlg.items;
                    curRecipe.number = dlg.number;
                }
            }
        }

        /// <summary>
        /// Add Receipe button click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddrec_Click(object sender, EventArgs e)
        {
            if (textBoxrecname.Text == "")
            {
                MessageBox.Show("Please include a Name for the Recipe!", "Please. . .");
            };
            if (textBox.Text == "")
            {
                MessageBox.Show("Please include a Description for the Recipe!", "Please. . .");
            }

            else
            {
            curRecipe.name = textBoxrecname.Text.ToString();
            curRecipe.des = textBox.Text.ToString();
            curRecipe.category = comboBox.Text.ToString();
            String listData = curRecipe.name + "\t\t" + curRecipe.number + "\t\t" + curRecipe.category + "\t\t" + curRecipe.des.Substring(0, Math.Min(curRecipe.des.Length, 15));
            if(manager.add(curRecipe))
                listBox.Items.Add(listData);
            textBoxrecname.Clear();
            textBox.Clear();
            comboBox.SelectedIndex = 0;
            curRecipe = new Recipe(numOfIng);
            };
            
        }
    }
}