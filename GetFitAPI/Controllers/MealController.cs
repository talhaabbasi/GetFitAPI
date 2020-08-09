using GetFitAPI.Models;
using GetFitAPI.Services.MealService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFitAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealController : ControllerBase
    {
        private readonly IMealService _mealService;

        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mealService.GetAllMeals());
        }

        [HttpGet("{MealId}")]
        public async Task<IActionResult> GetSingle(int MealId)
        {
            var response = await _mealService.GetMealById(MealId);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddMeal(Meal meal)
        {
            return Ok(await _mealService.AddMeal(meal));
        }
    }
}