using Microsoft.AspNetCore.Mvc;
using recipebook.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipebook.mvc.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var r = new Recipe
            {
                Id = "2",
                Title ="dddddd",
                Description = "wddwd",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        Name ="eeee",
                        Unit = Enum.MeasurementUnit.kg
                    }
                }
            };

            return View(r);
        }
    }
}
