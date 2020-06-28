//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FoodForm : Form
    {
        private List<string> m_ingredients = new List<string>();

        public Recipe Recipe { get; set; }

        public FoodForm()
        {
            InitializeComponent();
        }

        private void UpdateGUI() 
        {
            ingredientBox.Text = string.Empty;
            listBox1.Items.Clear();

            List<string> list = new List<string>();
            for (int i = 0; i < m_ingredients.Count; i++)
            {
                list.Add(m_ingredients[i]);
            }

            listBox1.Items.AddRange(printIngredients(list));
        }

        private string[] printIngredients(List<string> ingredients)
        {
            string[] arr = new string[ingredients.Count];
            int count = 0;
            foreach (string i in ingredients)
            {
                arr[count] = i;
                count++;
            }
            return arr;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddIngredient();
            }
            else
                MessageBox.Show("Fill out all the boxes with valid input!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            m_ingredients.RemoveAt(listBox1.SelectedIndex);
            UpdateGUI();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string Name = foodName.Text;

            Recipe = new Recipe(Name, m_ingredients);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientBox.Text = listBox1.SelectedItem.ToString();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, ingredientBox.Text);
        }

        private bool ValidateInput()
        {
            bool ok = (!string.IsNullOrEmpty(foodName.Text)) &
                      (!string.IsNullOrEmpty(ingredientBox.Text));
            return ok;
        }

        private void AddIngredient()
        {
            string ingredient = ingredientBox.Text;
            m_ingredients.Add(ingredient + ", ");
            UpdateGUI();
        }

        public string GetString() 
        {
            return Recipe.ToString();
        }

        public Recipe GetRecipe()
        {
            return Recipe;
        }

    }
}
