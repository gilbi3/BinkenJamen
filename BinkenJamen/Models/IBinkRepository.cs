using System.Collections.Generic;

namespace BinkenJamen.Models
{
	public interface IBinkRepository
	{
		void AddBink(Bink bink);

		void AddBinks(IEnumerable<Bink> binks);

		Bink GetBinkById(int id);

		IEnumerable<Bink> GetAllBinks();

		void RemoveBink(Bink bink);

		void UpdateBink(Bink bink);
	}
}