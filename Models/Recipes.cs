using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipesVersion2.Models
{
	public class Recipes
	{
        public int Id { get; set; }
        public string RecipeName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string Cuisine { get; set; }
        public string Course { get; set; }
        public string Url { get; set; }
        public IList<RecipeIngredient> RecipeIngredients { get; set; }
        public IEnumerable<Instruction> Instruction { get; set; }
    }
}
