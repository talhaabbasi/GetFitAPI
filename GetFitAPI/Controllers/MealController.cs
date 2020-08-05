using GetFitAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GetFitAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private static List<Meal> meals = new List<Meal> {
            new Meal(){ MealID = 1 , Calories = 100, MealType = new MealType(){ MealTypeID = 1 , Name = "Dinner"}, Name = "Kebabs"},
            new Meal(){ MealID = 2 , Calories = 200, MealType = new MealType(){ MealTypeID = 1 , Name = "Dinner"}, Name = "Fries"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(meals);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(meals.FirstOrDefault(meal => meal.MealID == id));
        }
    }
}