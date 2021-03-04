using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesVersion2.Models
{
	public class Cuisine
	{
		public int Id { get; set; }
		public string CuisineName { get; set; }
		public string ImagePath { get; set; }
		public string ImageURL { get; set; }
	}
}
