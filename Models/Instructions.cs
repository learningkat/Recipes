using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesVersion2.Models
{
	public class Instruction
	{
		public int Id { get; set; }
		public string InstructionText { get; set; }
		public Recipes Recipe { get; set; }
		public float Order { get; set; }
		public ICollection<RecipeIngredient> Ingredients { get; set; }
	}
}
