using System;

namespace BinkenJamen.Models
{
	public class Bink
	{
		public int Id { get; set; }
		public string Nickname { get; set; }
		public string ShortDescription { get; set; }
		public String LongDescription { get; set; }
		public string ImageUrl { get; set; }
		public string ThumbnailUrl { get; set; }
		public bool IsFavorite { get; set; }
	}
}