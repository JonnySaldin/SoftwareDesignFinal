using System.Windows.Forms;

namespace SoftwareDesignFinal
{
    public partial class Form1 : Form
    {
        // Dictionary to store recipes and their ingredients
        private Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>();

        private readonly IRecipeManager _recipeManager;

        public Form1(IRecipeManager recipeManager)
        {
            InitializeComponent();
            _recipeManager = recipeManager;
        }

        // Form Load event (not used, but can be used for initialization)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button1 - Add Recipe Click Event
        private void button1_Click(object sender, EventArgs e)
        {
            string recipeName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(recipeName))
            {
                MessageBox.Show("Please enter a recipe name.", "Error");
                return;
            }

            if (_recipeManager.AddRecipe(recipeName))
            {
                listBox1.Items.Add(recipeName);
                textBox1.Clear();
                MessageBox.Show($"Recipe '{recipeName}' added.");
            }
            else
            {
                MessageBox.Show($"Recipe '{recipeName}' already exists.", "Error");
            }
        }

        // Button2 - Add Ingredient Click Event
        private void button2_Click(object sender, EventArgs e)
        {
            string ingredient = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(ingredient))
            {
                MessageBox.Show("Please enter an ingredient.", "Error");
                return;
            }

            if (listBox1.SelectedItem is string selectedRecipe)
            {
                if (_recipeManager.AddIngredient(selectedRecipe, ingredient))
                {
                    MessageBox.Show($"Added '{ingredient}' to recipe '{selectedRecipe}'.");

                    // Update the RichTextBox with the updated ingredient list
                    var ingredients = _recipeManager.GetIngredientsForRecipe(selectedRecipe);
                    richTextBox1.Text = string.Join(Environment.NewLine, ingredients);

                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to add '{ingredient}' to recipe '{selectedRecipe}'.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe first.", "Error");
            }
        }

        // Recipe ListBox Selected Index Changed Event (display ingredients for the selected recipe)
        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is string selectedRecipe)
            {
                var ingredients = _recipeManager.GetIngredientsForRecipe(selectedRecipe);
                richTextBox1.Text = string.Join(Environment.NewLine, ingredients);
            }
        }

        // Placeholder event handlers (can be removed if not necessary)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }

}