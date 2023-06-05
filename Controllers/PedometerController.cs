using Health_And_Fitness_App.Data;
using Health_And_Fitness_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Health_And_Fitness_App.Controllers
{
    public class PedometerController : Controller
    {
        private readonly AppDbContext context;

        public PedometerController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return  context.calories.ToList() is null ? Problem() :  View(context.calories.ToList());
        }

        public IActionResult Steps()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StepsToCalories(Calorie calorie)
        {
            // Role  => TotalCaloriesBurned = NumOfSteps * 0.04
            double TotalCaloriesBurned = calorie.NumberOfSteps * 0.04;

            calorie.NumberOfSteps = calorie.NumberOfSteps;
            calorie.Date = DateTime.Now;
            context.calories.Add(calorie);
            context.SaveChanges();
            ViewBag.totalCaloriesBurned = TotalCaloriesBurned;
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = context.calories.Find(id);
            return View(record);
        }

        
        [HttpPost]
        public IActionResult Delete(Calorie record)
        {
            
            context.calories.Remove(record);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
