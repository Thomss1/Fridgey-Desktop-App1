using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeSuggestionApplicationProject
{
    public partial class HomePage : Form
    {
        private Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>
{
        { "American", new List<string> { "Pancakes", "Scrambled Eggs", "Cheese Sandwich", "Breakfast Burrito", "French Toast" } },
        { "Italian", new List<string> { "Frittata", "Italian Baked Eggs & Sausage", "Panettone", "Bruschetta", "Nutella Panettone" } },
        { "Filipino", new List<string> { "Tapsilog", "Pandesal", "Longganisa", "Champorado", "Hotdog Omelette" } },
        { "Mexican", new List<string> { "Chilaquiles", "Huevos Rancheros", "Tamales", "Molletes", "Breakfast Tacos" } },
        { "Polish", new List<string> { "Placki", "Zapiekanka", "Polish Scrambled Eggs", "Pierogi", "Kanapki" } }
};

        private Dictionary<string, (string Ingredients, string IngredientsList, string Steps)> recipeDetails = new Dictionary<string, (string, string, string)>
    {
        { "Pancakes",
          ("flour, milk, egg, baking powder, sugar",
          "1 cup all-purpose flour, 1 cup milk, 1 large egg, 1 tsp baking powder, 1 tbsp sugar",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. In a mixing bowl, combine the flour, baking powder, and sugar." + Environment.NewLine +
          "2. In another bowl, whisk together the milk and egg." + Environment.NewLine +
          "3. Pour the wet ingredients into the dry ingredients and mix until smooth." + Environment.NewLine +
          "4. Heat a skillet over medium heat and lightly grease it with butter or cooking spray." + Environment.NewLine +
          "5. Pour batter onto the skillet and cook until bubbles form on the surface. Flip and cook until golden brown." + Environment.NewLine +
          "Source: [Good Old-Fashioned Pancakes](https://www.allrecipes.com/recipe/21014/good-old-fashioned-pancakes/)") },

        { "Scrambled Eggs",
          ("egg, butter, salt",
          "2 large eggs, 1 tbsp unsalted butter, a pinch of salt",
          "Preparation Time: 2 minutes" + Environment.NewLine +
          "Cooking Time: 5 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Crack the eggs into a bowl and beat them with a fork." + Environment.NewLine +
          "2. Heat a skillet over medium heat and add butter." + Environment.NewLine +
          "3. Once the butter is melted, pour in the eggs." + Environment.NewLine +
          "4. Stir the eggs continuously until they are cooked to your desired consistency." + Environment.NewLine +
          "Source: [Chef John’s Scrambled Eggs](https://www.allrecipes.com/recipe/233060/chef-johns-scrambled-eggs/)") },

        { "Cheese Sandwich",
          ("cheese, bread, butter",
          "2 slices of bread, 2 slices of cheese, 1 tbsp unsalted butter",
          "Preparation Time: 3 minutes" + Environment.NewLine +
          "Cooking Time: 5 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Butter one side of each slice of bread." + Environment.NewLine +
          "2. Place one slice of cheese between the two slices of bread, with the buttered sides facing outward." + Environment.NewLine +
          "3. Grill the sandwich on a pan over medium heat until both sides are golden brown and the cheese is melted." + Environment.NewLine +
          "Source: [Grilled Cheese Sandwich](https://www.foodnetwork.com/recipes/food-network-kitchen/grilled-cheese-sandwich-recipe-2011629)") },

        { "Breakfast Burrito",
          ("tortilla, egg, sausage",
          "1 large tortilla, 2 large eggs, 1 sausage (any type)",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Scramble the eggs in a bowl." + Environment.NewLine +
          "2. Cook the sausage in a skillet over medium heat, breaking it into small pieces." + Environment.NewLine +
          "3. Add the scrambled eggs to the sausage and cook until the eggs are fully set." + Environment.NewLine +
          "4. Warm the tortilla in the skillet for a few seconds." + Environment.NewLine +
          "5. Place the egg and sausage mixture onto the tortilla, wrap it up, and serve." + Environment.NewLine +
          "Source: [Breakfast Burritos](https://www.foodnetwork.com/recipes/food-network-kitchen/breakfast-burritos-recipe-2011955)") },

        { "French Toast",
          ("bread, milk, egg",
          "2 slices of bread, 1/2 cup milk, 1 egg",
          "Steps:" + Environment.NewLine +
          "1. In a bowl, whisk together the egg and milk." + Environment.NewLine +
          "2. Dip the bread slices into the egg mixture, coating both sides." + Environment.NewLine +
          "3. Heat a skillet over medium heat and add butter." + Environment.NewLine +
          "4. Cook the bread until golden brown on both sides." + Environment.NewLine +
          "5. Serve with syrup, powdered sugar, or your favorite topping." + Environment.NewLine +
          "Source: [French Toast](https://www.allrecipes.com/recipe/7016/french-toast/)") },

         { "Frittata",
          ("egg, cheese, vegetables",
          "4 eggs, 1/2 cup grated cheese, 1 cup diced vegetables",
          "Preparation Time: 10 minutes" + Environment.NewLine +
          "Cooking Time: 15 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Beat eggs with cheese. Sauté vegetables in a skillet." + Environment.NewLine +
          "2. Pour egg mixture into skillet. Cook on low heat until set." + Environment.NewLine +
          "Source: [Italian Frittata](https://www.allrecipes.com/recipe/16466/italian-frittata/)") },

        { "Italian Baked Eggs & Sausage",
          ("egg, sausage, tomato sauce, herbs",
          "2 eggs, 2 sausages, 1 cup tomato sauce, 1 tsp Italian herbs",
          "Preparation Time: 10 minutes" + Environment.NewLine +
          "Cooking Time: 15 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Cook sausages in a skillet. Add tomato sauce and herbs." + Environment.NewLine +
          "2. Make wells in the sauce and crack eggs into them. Bake at 375°F until eggs are set." + Environment.NewLine +
          "Source: [Baked Eggs & Sausage](https://www.allrecipes.com/recipe/228608/baked-eggs-with-sausage-and-tomato-sauce/)") },

        { "Panettone",
          ("panettone bread, butter, sugar",
          "1 slice panettone, 1 tbsp butter, 1 tsp sugar",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 5 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Slice panettone. Spread butter and sprinkle sugar." + Environment.NewLine +
          "2. Toast in a skillet or oven until golden." + Environment.NewLine +
          "Source: [Panettone Recipe](https://www.allrecipes.com/recipe/232319/panettone-i/)") },

        { "Bruschetta",
          ("bread, tomato, basil, olive oil",
          "2 slices of bread, 1 diced tomato, 5 basil leaves, 1 tbsp olive oil",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 5 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Toast bread slices. Top with diced tomato and chopped basil." + Environment.NewLine +
          "2. Drizzle with olive oil and serve." + Environment.NewLine +
          "Source: [Classic Italian Bruschetta](https://www.allrecipes.com/recipe/54165/classic-bruschetta/)") },

        { "Nutella Panettone",
          ("panettone, Nutella",
          "1 slice panettone, 2 tbsp Nutella",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: None" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Spread Nutella on a slice of panettone and enjoy." + Environment.NewLine +
          "Source: [Nutella Panettone](https://www.nutella.com/world/en/)") },
        
        { "Tapsilog",
          ("beef, garlic, egg",
          "200g beef tapa, 3 cloves garlic (minced), 1 large egg, 1 cup cooked rice",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 15 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Cook the beef tapa in a skillet over medium heat until browned and cooked through." + Environment.NewLine +
          "2. In another pan, fry garlic rice by sautéing the minced garlic in oil, then mixing it with rice." + Environment.NewLine +
          "3. Fry an egg sunny-side-up." + Environment.NewLine +
          "4. Serve the beef tapa, garlic rice, and fried egg together." + Environment.NewLine +
          "Source: [Tapsilog](https://www.kawalingpinoy.com/tapsilog/)") },

        { "Pandesal",
          ("flour, sugar, yeast",
          "2 cups all-purpose flour, 1/4 cup sugar, 1 tsp active dry yeast, 1/2 cup warm milk, 1/4 cup breadcrumbs, a pinch of salt",
          "Preparation Time: 20 minutes (plus 1.5 hours rising time)" + Environment.NewLine +
          "Cooking Time: 20 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Mix together the flour, sugar, yeast, and salt in a bowl." + Environment.NewLine +
          "2. Add warm milk and knead the dough until smooth." + Environment.NewLine +
          "3. Let the dough rise in a warm place for 1 hour." + Environment.NewLine +
          "4. Shape the dough into small balls and roll them in breadcrumbs." + Environment.NewLine +
          "5. Place the balls on a baking sheet, let them rise for another 30 minutes, then bake at 375°F (190°C) for 20 minutes." + Environment.NewLine +
          "Source: [Pandesal](https://www.delish.com/cooking/recipe-ideas/a25444362/pandesal-recipe/)") },

        {"Longganisa",
          ("pork, garlic, vinegar",
          "200g ground pork, 5 cloves garlic (minced), 2 tbsp vinegar, 1 tbsp soy sauce, 1 tsp paprika, 1 tsp sugar, salt, and pepper to taste",
          "Preparation Time: 10 minutes" + Environment.NewLine +
          "Cooking Time: 20 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. In a bowl, combine the ground pork, garlic, vinegar, soy sauce, paprika, sugar, salt, and pepper. Mix well." + Environment.NewLine +
          "2. Shape the mixture into sausage links or patties." + Environment.NewLine +
          "3. Heat a skillet over medium heat and cook the sausages until browned on all sides and fully cooked." + Environment.NewLine +
          "Source: [Homemade Longganisa](https://www.kawalingpinoy.com/homemade-longganisa/)") },

        { "Champorado",
          ("chocolate, rice, milk",
          "1/2 cup cocoa powder or tablea chocolate, 1 cup glutinous rice, 4 cups water, 1 cup milk, sugar to taste",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 30 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. In a pot, cook the glutinous rice in water over medium heat, stirring occasionally, until the rice becomes soft and thick." + Environment.NewLine +
          "2. Add the cocoa powder or melted tablea chocolate and stir until fully dissolved." + Environment.NewLine +
          "3. Mix in sugar to taste." + Environment.NewLine +
          "4. Serve hot with milk drizzled on top or sweetened condensed milk." + Environment.NewLine +
          "Source: [Champorado](https://www.kawalingpinoy.com/champorado/)") },

        { "Hotdog Omelette",
          ("hotdog, egg, onion",
          "2 hotdogs (sliced), 2 large eggs, 1 small onion (chopped), 1 tbsp oil, salt, and pepper to taste",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Heat oil in a skillet over medium heat and sauté the sliced hotdogs and onions until lightly browned." + Environment.NewLine +
          "2. Beat the eggs in a bowl and season with salt and pepper." + Environment.NewLine +
          "3. Pour the eggs into the skillet and cook until the bottom is set." + Environment.NewLine +
          "4. Flip or fold the omelette and cook until fully set." + Environment.NewLine +
          "5. Serve hot." + Environment.NewLine +
          "Source: [Hotdog Omelette](https://www.delish.com/cooking/recipe-ideas/a25972142/hotdog-omelette/)") },

        { "Chilaquiles",
          ("tortilla, egg, salsa",
          "2 tortillas (cut into triangles), 2 large eggs, 1/2 cup salsa, 1/4 cup shredded cheese, oil for frying",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Heat oil in a skillet and fry the tortilla pieces until crispy. Remove and drain on paper towels." + Environment.NewLine +
          "2. In the same skillet, scramble the eggs until almost set, then add the salsa and stir to combine." + Environment.NewLine +
          "3. Add the fried tortilla pieces to the egg and salsa mixture, tossing gently to coat." + Environment.NewLine +
          "4. Sprinkle with cheese and serve immediately." + Environment.NewLine +
          "Source: [Chilaquiles](https://www.allrecipes.com/recipe/24537/chilaquiles/)") },

        { "Huevos Rancheros",
          ("egg, salsa, tortilla",
          "2 large eggs, 2 tortillas, 1/2 cup salsa, 1/4 cup crumbled cheese (e.g., queso fresco), 1 tbsp oil, salt, and pepper to taste",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Heat oil in a skillet and fry the tortillas until crispy. Set aside." + Environment.NewLine +
          "2. In the same skillet, fry the eggs sunny-side-up." + Environment.NewLine +
          "3. Place each fried egg on top of a tortilla and spoon salsa over the eggs." + Environment.NewLine +
          "4. Sprinkle with crumbled cheese and serve immediately." + Environment.NewLine +
          "Source: [Huevos Rancheros](https://www.allrecipes.com/recipe/233203/huevos-rancheros/)") },

        { "Tamales",
          ("cornmeal, meat, sauce",
          "1 cup masa harina or cornmeal, 1/2 cup broth, 1/4 cup lard or shortening, 100g cooked meat (shredded), 1/2 cup sauce (e.g., red or green salsa), corn husks for wrapping",
          "Preparation Time: 30 minutes" + Environment.NewLine +
          "Cooking Time: 60 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Soak corn husks in warm water until pliable." + Environment.NewLine +
          "2. In a bowl, mix masa harina with broth and lard until a smooth dough forms." + Environment.NewLine +
          "3. Spread a thin layer of dough onto a corn husk. Add meat and sauce in the center." + Environment.NewLine +
          "4. Fold the husk to enclose the filling and place in a steamer." + Environment.NewLine +
          "5. Steam for 60 minutes or until the tamales are firm." + Environment.NewLine +
          "6. Serve hot with extra sauce." + Environment.NewLine +
          "Source: [Authentic Mexican Tamales](https://www.allrecipes.com/recipe/17005/authentic-mexican-tamales/)") },

        { "Molletes",
          ("bread, beans, cheese",
          "1 baguette (sliced in half lengthwise), 1/2 cup refried beans, 1/2 cup shredded cheese, 1/4 cup salsa (optional)",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Preheat the oven to 375°F (190°C)." + Environment.NewLine +
          "2. Spread refried beans onto each half of the baguette." + Environment.NewLine +
          "3. Top with shredded cheese and bake until the cheese is melted and bubbly." + Environment.NewLine +
          "4. Serve warm with salsa on the side, if desired." + Environment.NewLine +
          "Source: [Molletes](https://www.mexicoinmykitchen.com/molletes-mexican-open-faced-sandwiches/)") },

        { "Breakfast Tacos",
          ("tortilla, egg, bacon",
          "2 small tortillas, 2 large eggs, 3 slices of bacon, 1/4 cup shredded cheese, salsa (optional)",
          "Preparation Time: 5 minutes" + Environment.NewLine +
          "Cooking Time: 10 minutes" + Environment.NewLine +
          "Steps:" + Environment.NewLine +
          "1. Cook the bacon in a skillet until crispy, then set aside." + Environment.NewLine +
          "2. Scramble the eggs in the same skillet until fully cooked." + Environment.NewLine +
          "3. Warm the tortillas and fill them with scrambled eggs, bacon, and shredded cheese." + Environment.NewLine +
          "4. Serve immediately with salsa, if desired." + Environment.NewLine +
          "Source: [Breakfast Tacos](https://www.allrecipes.com/recipe/256394/breakfast-tacos/)") },

        };



        public static HomePage Instance { get; private set; }
        public HomePage()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedCountries = grpCountries.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            var selectedIngredients = grpIngredients.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            if (!selectedCountries.Any())
            {
                MessageBox.Show("Please select at least one country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!selectedIngredients.Any())
            {
                MessageBox.Show("Please select at least one ingredient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var filteredRecipes = recipes
              .Where(r => selectedCountries.Contains(r.Key))
              .SelectMany(r => r.Value)
              .Where(recipe =>
              {
         var recipeIngredients = recipeDetails.ContainsKey(recipe)
             ? recipeDetails[recipe].Ingredients.ToLower().Split(',').Select(i => i.Trim())
             : Enumerable.Empty<string>();

             return selectedIngredients.Any(ingredient =>
             recipeIngredients.Contains(ingredient.ToLower()));
            })
            .ToList();

            if (!filteredRecipes.Any())
            {
                MessageBox.Show("No recipes found matching the selected criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SearchResults searchResultsForm = new SearchResults(filteredRecipes, recipeDetails);
            searchResultsForm.Show();
            this.Hide();
        }

        public void AddToMealPlanner(string day, string timeSlot, string recipe)
        {
            foreach (ListViewItem existingItem in listMealPlanner.Items)
            {
                if (existingItem.SubItems[0].Text == day && existingItem.SubItems[1].Text == timeSlot && existingItem.SubItems[2].Text == recipe)
                {
                    MessageBox.Show($"{recipe} is already added for {day} at {timeSlot}.", "Error");
                    return;
                }
            }
            var item = new ListViewItem(day);
            item.SubItems.Add(timeSlot);
            item.SubItems.Add(recipe);
            listMealPlanner.Items.Add(item);
        }



        private void LoadMealPlans()
        {

            List<MealPlan> mealPlans = MealPlannerDatabase.LoadMealPlans();
            foreach (var mealPlan in mealPlans)
            {
                var item = new ListViewItem(mealPlan.Day);
                item.SubItems.Add(mealPlan.TimeSlot);
                item.SubItems.Add(mealPlan.RecipeName);

                listMealPlanner.Items.Add(item);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadMealPlans();
        }

        private void chkAmerica_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearMealPlanner_Click_1(object sender, EventArgs e)
        {
            listMealPlanner.Items.Clear();
            MealPlannerDatabase.ClearMealPlans();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listMealPlanner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

