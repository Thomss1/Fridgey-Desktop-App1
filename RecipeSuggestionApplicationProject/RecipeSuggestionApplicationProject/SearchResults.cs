using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RecipeSuggestionApplicationProject
{
    public partial class SearchResults : Form
    {
        private List<string> recipes;
        private Dictionary<string, (string Ingredients, string IngredientsList, string Steps)> recipeDetails;

        // Images from the resources
        private Dictionary<string, Image> recipeImages = new Dictionary<string, Image>
        {
            { "Pancakes", Properties.Resources.Pancakes },
            { "Scrambled Eggs", Properties.Resources.ScrambledEggs },
            { "Cheese Sandwich", Properties.Resources.CheeseSandwich },
            { "Breakfast Burrito", Properties.Resources.BreakfastBurrito },
            { "French Toast", Properties.Resources.FrenchToast },
            { "Frittata", Properties.Resources.Frittata },
            { "Italian Baked Eggs & Sausage", Properties.Resources.ItalianBakedEggs_Sausage },
            { "Panettone", Properties.Resources.Panettone },
            { "Bruschetta", Properties.Resources.Bruschetta },
            { "Nutella Panettone", Properties.Resources.NutellaPanettone },
            { "Tapsilog", Properties.Resources.Tapsilog },
            { "Pandesal", Properties.Resources.Pandesal },
            { "Longganisa", Properties.Resources.Longganisa },
            { "Champorado", Properties.Resources.Champorado },
            { "Hotdog Omelette", Properties.Resources.HotdogOmelette },
            { "Chilaquiles", Properties.Resources.Chilaquiles },
            { "Huevos Rancheros", Properties.Resources.HuevosRancheros },
            { "Tamales", Properties.Resources.Tamales },
            { "Molletes", Properties.Resources.Molletes },
            { "Breakfast Tacos", Properties.Resources.BreakfastTacos },
            { "Placki", Properties.Resources.Placki },
            { "Kanapki", Properties.Resources.Kanapki },
            { "Zapiekanka", Properties.Resources.Zapiekanka },
            { "Polish Scrambled Eggs", Properties.Resources.PolishScrambledEggs },
            { "Pierogi", Properties.Resources.Pierogi },
            { "Default", Properties.Resources.DefaultImage }
        };

        public SearchResults(List<string> filteredRecipes, Dictionary<string, (string Ingredients, string IngredientsList, string Steps)> recipeDetails)
        {
            InitializeComponent();
            recipes = filteredRecipes;
            this.recipeDetails = recipeDetails;
            MessageBox.Show($"Recipes Count: {recipes?.Count ?? 0}");
            DisplayRecipes();
        }

        private async Task LoadRecipeImageAsync(PictureBox pictureBox, string recipeName)
        {
            await Task.Run(() =>
            {
                if (recipeImages.ContainsKey(recipeName))
                {
                    pictureBox.Image = recipeImages[recipeName];
                }
                else
                {
                    pictureBox.Image = recipeImages["Default"];
                }
            });
        }

        private async void DisplayRecipes()
        {
            flpRecipes.Controls.Clear();

            if (recipes == null || recipes.Count == 0)
            {
                MessageBox.Show("No recipes to display!");
                return;
            }

            int pictureBoxWidth = flpRecipes.ClientSize.Width / 3 - 10;
            int pictureBoxHeight = pictureBoxWidth;

            foreach (var recipe in recipes)
            {
                Panel recipePanel = new Panel
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight + 30), 
                    Padding = new Padding(0, 0, 0, 10), 
                    Margin = new Padding(5)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = recipe
                };

                await LoadRecipeImageAsync(pictureBox, recipe);

                pictureBox.Click += RecipeClick;

                Label recipeLabel = new Label
                {
                    Text = recipe,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom, 
                    Height = 20,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                recipePanel.Controls.Add(pictureBox);
                recipePanel.Controls.Add(recipeLabel);

                flpRecipes.Controls.Add(recipePanel);
            }

            flpRecipes.Refresh();
        }



        private void RecipeClick(object sender, EventArgs e)
        {
            PictureBox clickedPicture = (PictureBox)sender;
            string selectedRecipe = clickedPicture.Tag.ToString();

            if (!recipeDetails.ContainsKey(selectedRecipe))
            {
                MessageBox.Show("Recipe details not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var details = recipeDetails[selectedRecipe];
            string ingredients = details.IngredientsList;
            string steps = details.Steps;

            Image recipeImage = recipeImages.ContainsKey(selectedRecipe)
                ? recipeImages[selectedRecipe]
                : recipeImages["Default"];

            RecipePage recipePage = new RecipePage(HomePage.Instance, selectedRecipe, recipeImage, ingredients, steps);
            recipePage.Show();
            this.Hide();    
        }

        private void flpRecipes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage back = new HomePage();
            back.Show();
        }
    }
}
