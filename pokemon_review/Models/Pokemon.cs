﻿
namespace pokemon_review.Models
{
	public class Pokemon
	{

		public int ID { get; set; }

		public string Name { get; set; }

		public DateTime BirthDate { get; set; }
		public ICollection<Review> Reviews {get; set ;}
		
	}
}

   