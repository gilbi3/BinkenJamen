using BinkenJamen.Models;
using BinkenJamen.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BinkenJamen.Controllers
{
	public class BinkController : Controller
	{
		private readonly IBinkRepository _repo;

		public BinkController(IBinkRepository binkRepository)
		{
			_repo = binkRepository;
		}

		// GET: /Bink/
		public IActionResult Index()
		{
			var binkViewModel = new BinkViewModel()
			{
				Title = "BINK",
				Binks = _repo.GetAllBinks().ToList()
			};
			return View(binkViewModel);
		}

		public IActionResult CloseUp(int id)
		{
			var bink = _repo.GetBinkById(id);
			if (bink == null)
			{
				return NotFound();
			}

			return View(bink);
		}

		// GET
		public IActionResult AddBink()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBink(Bink bink)
		{
			if (ModelState.IsValid)
			{
				Console.WriteLine("Saving Bink...");
				_repo.AddBink(bink);
				return RedirectToAction("Index");
			}
			else
			{
				Console.WriteLine("Unable to submit Bink...");
				return View();
			}
		}
	}
}