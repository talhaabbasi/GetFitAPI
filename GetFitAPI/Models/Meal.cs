namespace GetFitAPI.Models
{
    public class Meal
    {
        public int MealID { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public MealType MealType { get; set; }
    }
}