using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RecipeSuggestionApplicationProject;

public static class MealPlannerDatabase
{
    private static string filePath = "mealPlans.json";
    public static void SaveMealPlans(List<MealPlan> mealPlans)
    {
        try
        {
            string json = JsonConvert.SerializeObject(mealPlans, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving meal plans: {ex.Message}");
        }
    }
    public static List<MealPlan> LoadMealPlans()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                return JsonConvert.DeserializeObject<List<MealPlan>>(json);
            }
            else
            {
                return new List<MealPlan>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading meal plans: {ex.Message}");
            return new List<MealPlan>();
        }
    }
    public static void ClearMealPlans()
    {
        List<MealPlan> emptyList = new List<MealPlan>();
        string json = JsonConvert.SerializeObject(emptyList, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}

