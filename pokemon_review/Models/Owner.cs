using System;


namespace pokemon_review.Models
{
	public class Owner
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Gym { get; set; }

		public ICollection<Review> Reviews { get; set; }
	}
}

