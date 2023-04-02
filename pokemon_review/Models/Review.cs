using System;
namespace pokemon_review.Models
{
	public class Review
	{
		public int Id { set; get; }
		public string Title { set; get; }
		public string Text { set; get;   }
		public Reviewer Reviewer { set; get; }
		public Pokemon Pokemon { get; set;  }
	}
}

