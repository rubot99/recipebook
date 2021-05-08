using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipebook.mvc.Models
{
    public class Recipe
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public DateTime Created { get; set; } = new DateTime();
    }
}
