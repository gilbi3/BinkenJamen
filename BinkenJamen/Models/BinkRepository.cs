using BinkenJamen.Data;
using System.Collections.Generic;
using System.Linq;

namespace BinkenJamen.Models
{
	public class BinkRepository : IBinkRepository
	{
		private static BinkContext _context = new BinkContext();

		public static void InitializeBinks()
		{
			var _binks = new List<Bink>{
				new Bink{Nickname = "Binken Jamen", ShortDescription = "The most prominent among Binks", LongDescription = "A Champion of the people, Lorem Ipsum ladi da di da, etc et cetera.", ImageUrl= "/img/binkenjamen.jpg", ThumbnailUrl="wwwroot/img/binkenjamen.jpg", IsFavorite=true }
			};
			_context.Add(_binks[0]);
			_context.SaveChanges();
		}

		public void AddBink(Bink bink)
		{
			_context.Add(bink);
			_context.SaveChanges();
		}

		public void AddBinks(IEnumerable<Bink> binks)
		{
			_context.Add(binks);
			_context.SaveChanges();
		}

		public IEnumerable<Bink> GetAllBinks()
		{
			var binks = _context.Binks.ToList<Bink>();
			return binks;
		}

		public Bink GetBinkById(int id)
		{
			var desiredBink = _context.Binks.Where(b => b.Id == id).FirstOrDefault<Bink>();
			return desiredBink;
		}

		public void RemoveBink(Bink bink)
		{
			_context.Remove(bink);
			_context.SaveChanges();
		}

		public void UpdateBink(Bink bink)
		{
			_context.Binks.Update(bink);
			_context.SaveChanges();
		}
	}
}