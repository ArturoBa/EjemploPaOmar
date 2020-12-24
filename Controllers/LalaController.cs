using APIpaOmar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpaOmar.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class LalaController : Controller
	{
		private Contexto _db;
		public LalaController(Contexto db)
		{
			_db = db;
		}
		public JsonResult Index()
		{
			var sp = _db.Jaja.FromSqlRaw("EXEC Jojo").ToList();
			var data = sp.ToList();

			return new JsonResult(new { data });
		}
	}
}
