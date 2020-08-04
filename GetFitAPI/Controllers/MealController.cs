using GetFitAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(meals);
        }

        public IActionResult GetSingle()
        {
            return Ok(meals[1]);
        }
    }
}