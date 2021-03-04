using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesVersion2.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string CourseName { get; set; }
		public string ImagePath{ get; set; }
		public string ImageURL { get; set; }
	}
}
