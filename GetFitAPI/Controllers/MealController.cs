using GetFitAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetFitAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private static Meal meal = new Meal();

        public IActionResult Get()
        {
            return Ok(meal);
        }
    }
}