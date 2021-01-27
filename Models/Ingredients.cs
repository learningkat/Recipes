using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesVersion2.Models
{
	public class Ingredient
	{
		public int Id { get; set; }
		public string IngredientName { get; set; }
		public ICollection<Unit> Units { get; set; }


	}
}
