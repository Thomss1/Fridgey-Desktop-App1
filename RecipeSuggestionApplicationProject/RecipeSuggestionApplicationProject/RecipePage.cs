using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecipeSuggestionApplicationProject
{
    public partial class RecipePage : Form
    {
        private string recipeName;
        private Image recipeImage;
        private string recipeIngredients;
        private string recipeSteps;
        private HomePage homePage;

        public RecipePage(HomePage homePage, string name, Image image, string ingredientsList, string steps)
        {
            InitializeComponent();

            this.homePage = homePage;
            recipeName = name;
            recipeImage = image;
            recipeIngredients = ingredientsList;
            recipeSteps = steps;

            LoadRecipeDetails();
        }


        private void LoadRecipeDetails()
        {
            lblRecipeName.Text = recipeName;
            pbRecipeImage.Image = recipeImage ?? Properties.Resources.DefaultImage;
            txtIngredients.Text = string.IsNullOrEmpty(recipeIngredients) ? "Ingredients not available" : recipeIngredients;
            txtSteps.Text = string.IsNullOrEmpty(recipeSteps) ? "Steps not available" : recipeSteps;
        }


        private void RecipePage_Load(object sender, EventArgs e)
        {
            comboDay.Items.AddRange(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            comboTimeSlot.Items.AddRange(new string[] { "Breakfast", "Lunch", "Dinner", "8:00 AM", "12:00 PM", "6:00 PM" });
        }


        private void btnAddToPlanner_Click(object sender, EventArgs e)
        {
            if (comboDay.SelectedItem != null && comboTimeSlot.SelectedItem != null)
            {
                string selectedDay = comboDay.SelectedItem.ToString();
                string selectedTime = comboTimeSlot.SelectedItem.ToString();

                MealPlan newMealPlan = new MealPlan
                {
                    Day = selectedDay,
                    TimeSlot = selectedTime,
                    RecipeName = recipeName
                };

                homePage.AddToMealPlanner(selectedDay, selectedTime, recipeName);

                List<MealPlan> mealPlans = MealPlannerDatabase.LoadMealPlans();

                if (!mealPlans.Any(m => m.Day == selectedDay && m.TimeSlot == selectedTime && m.RecipeName == recipeName))
                {

                    mealPlans.Add(newMealPlan);

                    MealPlannerDatabase.SaveMealPlans(mealPlans);

                    MessageBox.Show($"{recipeName} has been added to the meal planner for {selectedDay} at {selectedTime}!", "Success");
                }
                else
                {
                    MessageBox.Show($"{recipeName} is already added to the meal planner for {selectedDay} at {selectedTime}.", "Error");
                }

                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select both a day and a time slot to add to the meal planner.", "Error");
            }
        }



        private void lblRecipeName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage back1 = new HomePage();
            back1.Show();

        }
    }
}
