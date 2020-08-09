using GetFitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFitAPI.Services.MealService
{
    public interface IMealService
    {
        Task<ServiceResponse<List<Meal>>> GetAllMeals();

        Task<ServiceResponse<Meal>> GetMealById(int MealId);

        Task<ServiceResponse<List<Meal>>> AddMeal(Meal meal);
    }
}