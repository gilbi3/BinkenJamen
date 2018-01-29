using BinkenJamen.Models;
using System.Collections.Generic;

namespace BinkenJamen.ViewModels
{
	public class BinkViewModel
	{
		public string Title { get; set; }
		public List<Bink> Binks { get; set; }
	}
}