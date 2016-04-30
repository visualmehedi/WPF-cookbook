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
    public partial class FormIngredients : Form
    {
        private int i = 0;
        private string[] ingrList = new string[10];

        /// <summary>
        /// constructor
        /// </summary>
        public FormIngredients()
        {
            InitializeComponent();
            IntializeGUI();
        }

        /// <summary>
        /// GUI initialization
        /// </summary>
        private void IntializeGUI()
        {
            listBox.Items.Clear();
            listBox.Update();
            listBox.Refresh();
        }

        /// <summary>
        /// click action for Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((textBoxIng.Text == "")|| (textBoxIng.Text == " "))
            {
                MessageBox.Show("Please include a Name for the Ingredient!", "Please. . .");
            }

            else
            { if (i < 20)
                {
                    listBox.Items.Add(textBoxIng.Text.ToString());
                    ingrList[i++] = textBoxIng.Text.ToString();
                    label2.Text = i.ToString();
                    textBoxIng.Clear();                
                }
            }            
        }

        /// <summary>
        /// to get ingredient list
        /// </summary>
        public string[] items
        {
            get { return this.ingrList; }
        }

        public int number
        {
            get { return this.i; }
        }

        private void textBoxIng_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}