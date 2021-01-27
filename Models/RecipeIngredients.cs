using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesVersion2.Models
{
	public class RecipeIngredient
	{
		public int Id { get; set; }
		public Ingredient RecipeIngredientName { get; set; }
		public float Quantity { get; set; }
		public Unit Unit { get; set; }
	}
}
