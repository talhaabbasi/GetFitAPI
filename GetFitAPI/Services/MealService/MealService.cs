using GetFitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFitAPI.Services.MealService
{
    public class MealService : IMealService
    {
        private static List<Meal> meals = new List<Meal> {
            new Meal(){ MealID = 1 , Calories = 100, MealType = new MealType(){ MealTypeID = 1 , Name = "Dinner"}, Name = "Kebabs"},
            new Meal(){ MealID = 2 , Calories = 200, MealType = new MealType(){ MealTypeID = 1 , Name = "Dinner"}, Name = "Fries"}
        };

        public async Task<ServiceResponse<List<Meal>>> AddMeal(Meal meal)
        {
            ServiceResponse<List<Meal>> serviceResponse = new ServiceResponse<List<Meal>>();
            meals.Add(meal);
            serviceResponse.Data = meals;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Meal>>> GetAllMeals()
        {
            ServiceResponse<List<Meal>> serviceResponse = new ServiceResponse<List<Meal>>();
            serviceResponse.Data = meals;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Meal>> GetMealById(int MealId)
        {
            ServiceResponse<Meal> serviceResponse = new ServiceResponse<Meal>();
            Meal meal = meals.FirstOrDefault(meal => meal.MealID == MealId);
            serviceResponse.Data = meal;
            return serviceResponse;
        }
    }
}